using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CmgPrsrDropCal
{

    public class Indata
    {

        public double inletPrsr;
        public double inletOilRate;
        public double inletWaterRate;
        public double inletGasRate;
        public double pipeId;
        public double pipeLength;
        public double incliantion;
        public double oilVis;
        public double gasVis;
        public double waterVis;
        public string filePath = string.Empty;


    }

    public class Outdata
    {

        public double TotaPressureGradient;
        public double FrictionGradient;
        public double GraivityGradient;
        public double TotalPressureDrop;
        public string ErrorMessage = string.Empty;


    }

    public class PrsrDrop
    {

        private string mErrMsg;
        private Outdata mOutdata;

        

        //SS:---- Constructor ------
        public PrsrDrop()
        {
            mErrMsg = string.Empty;
            mOutdata = new Outdata();

        }

       

        //SS:-------- Output variables
        public double pressureDrop { get; set; }
        public string erroMsg { get; set; }



        //SS:--------------------- Pressure drop calculation ----------------
        public Outdata RunPressDropCal(Indata mIndata)
        {
            double rs, bo, bg, area, qo, qw, ql, vsl, vm, qg, vsg, lamdaL;
            double fo, rhoO, rhoG, rhoW, rhoL,rhoNs, muO, muW, muL, muG, muNs, NRey, f, inclinationAngleRadians;
            double frictionGrad, gravityGrad, totalGrad;


            try
            {
                                
                rs = 0.0461 * Math.Pow(mIndata.inletPrsr, 1.205);
                bo = 0.972 + Math.Pow(rs * 0.00048 + 0.1026, 1.175);
                bg = 16 / mIndata.inletPrsr;

                area = 0.7854 * Math.Pow((mIndata.pipeId / 12), 2);

                qo = (mIndata.inletOilRate * bo * 5.614) / 86400;
                qw = 0.00;
                ql= qo + qw;
                vsl = ql / area;

                qg = ((mIndata.inletGasRate * 1000000 - (mIndata.inletOilRate * rs)) * bg) / 86400;
                vsg = qg / area;

                vm = vsl + vsg;

                lamdaL = ql / (ql + qg);               


                fo = mIndata.inletOilRate / (mIndata.inletOilRate + mIndata.inletWaterRate);                
                rhoO = (53.04 + 0.01254 * rs) / bo;
                rhoG = 0.0028 * mIndata.inletPrsr;
                rhoW = 62.4;
                rhoL = rhoO * fo + rhoW * (1 - fo);
                rhoNs = rhoL * lamdaL + rhoG * (1 - lamdaL);

                muO = mIndata.oilVis;  // Assuming oil viscosity in cP
                muW = mIndata.waterVis;  // Assuming water viscosity in cP
                muL = muO * fo + muW * (1 - fo);
                muG = mIndata.gasVis;
                muNs = muL * lamdaL + muG * (1 - lamdaL);

                NRey = (rhoNs * vm * mIndata.pipeId / 12);

                f = 0.0056 + 0.5 * Math.Pow(NRey, -0.32) / muNs;

                frictionGrad = f * rhoNs * Math.Pow(vm, 2) / (2 * 32.174* mIndata.pipeId / 12);

                inclinationAngleRadians = Math.PI * mIndata.incliantion / 180.0;


                gravityGrad = rhoNs * Math.Sin(inclinationAngleRadians);

                totalGrad = (frictionGrad + gravityGrad)/144;

                pressureDrop = totalGrad* mIndata.pipeLength;


                //SS:----- Assign the results

                mOutdata.FrictionGradient = frictionGrad;
                mOutdata.GraivityGradient = gravityGrad;
                mOutdata.TotaPressureGradient = totalGrad;
                mOutdata.TotalPressureDrop = pressureDrop;
                mOutdata.ErrorMessage = mErrMsg;

            }
            catch (Exception ex)
            {       
               
                mErrMsg += ex.Message.ToString();
                mOutdata.ErrorMessage += mErrMsg;

            }

            erroMsg = mErrMsg;
            return mOutdata;
            
        }




        //public void getDefaultInputData()
        //{
        //    inletPrsr = 7239540 * 0.000145; // in psi
        //    inletOilRate = 158.99 * 6.2898106;// in stb/d
        //    inletWaterRate = 0.0 * 6.2898106; // in stb/d
        //    inletGasRate = 28316.85 * 35.3147248/1000000 ;  ///28316.85; in MMscf/d
        //    pipeId = 0.050673 * 39.3700787; // in inch
        //    pipeLength = 152.4 * 3.2808399; // in feet
        //    incliantion = 30;
        //    oilVis = 0.002 * 1000; // in Cp
        //    gasVis = 0.000015 * 1000;// in Cp
        //    waterVis = 0.001 * 1000;// in Cp

        //}




    }




}
