using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CmgPrsrDropCal
{ 
    
    public class PrsrDrop
    {

        private string mErrMsg;

        public PrsrDrop()
        {
            mErrMsg = string.Empty;
        }

        public double inletPrsr { get; set; }
        public double inletOilRate { get; set; }
        public double inletWaterRate { get; set; }
        public double inletGasRate { get; set; }
        public double pipeId { get; set; }
        public double pipeLength { get; set; }
        public double incliantion { get; set; }
        public double oilVis { get; set; }
        public double gasVis { get; set; }
        public double waterVis { get; set; }


        // Output variables
        public double pressureDrop { get; set; }
        public string erroMsg { get; set; }






        public void getDefaultInputData()
        {
            inletPrsr = 7239540 * 0.000145; // in psi
            inletOilRate = 158.99 * 6.2898106;// in stb/d
            inletWaterRate = 0.0 * 6.2898106; // in stb/d
            inletGasRate = 28316.85 * 35.3147248/1000000 ;  ///28316.85; in MMscf/d
            pipeId = 0.050673 * 39.3700787; // in inch
            pipeLength = 152.4 * 3.2808399; // in feet
            incliantion = 30;
            oilVis = 0.002 * 1000; // in Cp
            gasVis = 0.000015 * 1000;// in Cp
            waterVis = 0.001 * 1000;// in Cp

        }


        // Pressure drop calculation


        public bool RunPressDropCal()
        {
            bool isRunOk = true;


            try
            {

                // Calculate correlations
                //double P = inletPrsr;
                //double D = pipeId;  // feet
                //double L = pipeLength;

                //double area = Math.PI * Math.Pow(D / 2, 2);


                //double Bg = 16 / P;
                //double rhoO = (53.04 + 0.01254 * Rs) / Bo;
                //double rhoG = 0.0028 * P;
                //double rhoW = 62.4;
                //double fo = inletOilRate / (inletOilRate + inletWaterRate);
                //double rhoL = rhoO * fo + rhoW * (1 - fo);
                //double muO = oilVis;  // Assuming oil viscosity in cP
                //double muW = waterVis;  // Assuming water viscosity in cP
                //double muL = muO * fo + muW * (1 - fo);
                //double muG = gasVis;

                //double Vso = inletOilRate * Bo / area;
                //double Vsw = inletWaterRate / area;
                //double Vsl = Vso * fo + Vsw * (1 - fo);
                //double GOR = inletGasRate / inletOilRate;
                //double Vsg = inletOilRate * (GOR - Rs) * Bg / area;



                
                double rs = 0.0461 * Math.Pow(inletPrsr, 1.205);
                double bo = 0.972 + Math.Pow(rs * 0.00048 + 0.1026, 1.175);
                double bg = 16 / inletPrsr;

                //-----------------------------------------------
                //double lambdaL = GetLiquidHoldup(inletOilRate, inletGasRate, bo, bg, rs, pipeId
                //


                double area = 0.7854 * Math.Pow((pipeId / 12), 2);
                double qo = (inletOilRate * bo * 5.614) / 86400;
                double qw = 0.00;
                double ql= qo + qw;


                double vsl = ql / area;

                double qg = ((inletGasRate * 1000000 - (inletOilRate * rs)) * bg) / 86400;

                double vsg = qg / area;

                double vm = vsl + vsg;

                double lamdaL = ql / (ql + qg);

                //--------------------------
                double fo = inletOilRate / (inletOilRate + inletWaterRate);                
                double rhoO = (53.04 + 0.01254 * rs) / bo;
                double rhoG = 0.0028 * inletPrsr;
                double rhoW = 62.4;
                double rhoL = rhoO * fo + rhoW * (1 - fo);
                double rhoNs = rhoL * lamdaL + rhoG * (1 - lamdaL);

                double muO = oilVis;  // Assuming oil viscosity in cP
                double muW = waterVis;  // Assuming water viscosity in cP
                double muL = muO * fo + muW * (1 - fo);
                double muG = gasVis;
                double muNs = muL * lamdaL + muG * (1 - lamdaL);

                double NRey = (rhoNs * vm * pipeId / 12);

                double f = 0.0056 + 0.5 * Math.Pow(NRey, -0.32) / muNs;

                // f = 0.0068;


                double frictionGrad = f * rhoNs * Math.Pow(vm, 2) / (2 * 32.174* pipeId / 12);

                double inclinationAngleRadians = Math.PI * incliantion / 180.0;


                double gravityGrad = rhoNs * Math.Sin(inclinationAngleRadians);

                double totalGrad = (frictionGrad + gravityGrad)/144;

                //double pd = f * (pipeLength / (pipeId/12)) * (rhoNs * Math.Pow(vm, 2)) / 2;



                pressureDrop = totalGrad* pipeLength;

                // Calculate homogeneous model variables
                ////double Vm = Vsl + Vsg;
                ////double lambdaL = Vsl / Vm;
                //double rhoNs = rhoL * lambdaL + rhoG * (1 - lambdaL);
                //double muNs = muL * lambdaL + muG * (1 - lambdaL);

                //// Calculate dimensionless Reynolds number
                //double NRey = (rhoNs * Vm * D) / muNs;

                //// Calculate friction factor
                //double f = 0.0056 + 0.5 * Math.Pow(NRey, -0.32);

                //// Calculate pressure drop using Darcy-Weisbach equation
                //double pd = f * (L / D) * (rhoNs * Math.Pow(Vm, 2)) / 2;



               // pressureDrop = pd;



                // mErrMsg += "No Error";

            }
            catch (Exception ex)
            {
                isRunOk = false;
                Console.WriteLine(ex.Message.ToString());
                mErrMsg += ex.Message.ToString();

            }

            erroMsg = mErrMsg;
            return isRunOk;
            ;
        }



        public double GetLiquidHoldup(double qosc,double qgsc, double bo, double bg, double rs, double pipeId)

        {
            double lamdaL = 0.0;
            double area,ql, qg, qo,qw;
            double vsl, vsg, vm;

            try
            {
                area = 0.7854 * Math.Pow((pipeId/12),2);
                qo = (qosc * bo * 5.614) / 86400;
                qw = 0.00;
                ql = qo + qw;


                vsl = ql / area;

                qg = ((qgsc *1000000 - (qosc * rs)) * bg)/86400;

                vsg = qg / area;

                vm = vsl + vsg;

                lamdaL = ql / (ql + qg);


            }
            catch (Exception)
            {

                mErrMsg += "Error at calculating the liquid hold up";
            }

            return lamdaL;
        }


        //**************************************** Extra Code ************************

        public bool RunPressDropCal_v0()
        {
            bool isRunOk = true;


            try
            {

                // Calculate correlations
                double P = inletPrsr;
                double D = pipeId;  // feet
                double L = pipeLength;

                double area = Math.PI * Math.Pow(D / 2, 2);
                double Rs = 0.0461 * Math.Pow(P, 1.205);
                double Bo = 0.972 + Math.Pow(Rs * 0.00048 + 0.1026, 1.175);
                double Bg = 16 / P;
                double rhoO = (53.04 + 0.01254 * Rs) / Bo;
                double rhoG = 0.0028 * P;
                double rhoW = 62.4;
                double fo = inletOilRate / (inletOilRate + inletWaterRate);
                double rhoL = rhoO * fo + rhoW * (1 - fo);
                double muO = oilVis;  // Assuming oil viscosity in cP
                double muW = waterVis;  // Assuming water viscosity in cP
                double muL = muO * fo + muW * (1 - fo);
                double muG = gasVis;

                double Vso = inletOilRate * Bo / area;
                double Vsw = inletWaterRate / area;
                double Vsl = Vso * fo + Vsw * (1 - fo);
                double GOR = inletGasRate / inletOilRate;
                double Vsg = inletOilRate * (GOR - Rs) * Bg / area;

                // Calculate homogeneous model variables
                double Vm = Vsl + Vsg;
                double lambdaL = Vsl / Vm;
                double rhoNs = rhoL * lambdaL + rhoG * (1 - lambdaL);
                double muNs = muL * lambdaL + muG * (1 - lambdaL);

                // Calculate dimensionless Reynolds number
                double NRey = (rhoNs * Vm * D) / muNs;

                // Calculate friction factor
                double f = 0.0056 + 0.5 * Math.Pow(NRey, -0.32);

                // Calculate pressure drop using Darcy-Weisbach equation
                double pd = f * (L / D) * (rhoNs * Math.Pow(Vm, 2)) / 2;



                pressureDrop = pd;



                mErrMsg += "No Error";

            }
            catch (Exception ex)
            {
                isRunOk = false;
                Console.WriteLine(ex.Message.ToString());
                mErrMsg += ex.Message.ToString();

            }

            erroMsg = mErrMsg;
            return isRunOk;
            ;
        }





    }

   


}
