using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio03
{
    public partial class ejercicio03 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEvaluar_Click(object sender, EventArgs e)
        {

            if (TextEdad.Text.Equals("") || TextPromedio.Text.Equals(""))
            {
                Response.Write("<script> alert('Valores sin datos');</script>");
            }
            else
            {
                int Edad = int.Parse(TextEdad.Text);
                double Promedio = double.Parse(TextPromedio.Text);
                double Beca = 0;

                if (Edad < 18 && Promedio <= 65)
                {
                    Beca = 200000;
                }
                else if (Edad < 18 && Promedio <= 60 || Promedio >=65)
                {
                    Beca = 100000;
                }
                else if (Edad < 18 && Promedio > 60)
                {
                    Response.Write("<script> alert('Se recomienda estudiar mas');</script>");
                }
                else if (Edad > 18 && Promedio <= 65)
                {
                    Beca = 220000;
                }
                else if (Edad > 18 && Promedio <= 60 || Promedio >=65)
                {
                    Beca = 120000;
                }
                else if (Edad > 18 && Promedio > 60 )
                {
                    Response.Write("<script> alert('Se recomienda estudiar mas');</script>");
                }
                else 
                {
                   Response.Write("<script> alert('Valores sin datos');</script>");
                }


                TextBeca.Text = "$" + Beca.ToString("N0");


            }
        
        }
    }
}