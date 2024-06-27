using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte2
{
    public class Controlador
    {
        public int[] CodigosPostales = new int[100];
        public double[] PesosGr = new double[100];
        public int[] EmpresasDistribucion = new int[100];
        public double[] Pagos = new double[100];
        public int Contador;

        public void Despachar(int codigoPostal, double peso, int empresaDistribucion, bool EsCertificada, ref double CostoBase, ref double IVA, ref double CostoAPagar)
        {
            CodigosPostales[Contador] = codigoPostal;
            PesosGr[Contador] = peso;
            EmpresasDistribucion[Contador] = empresaDistribucion;
            if (EsCertificada)
            {
                CostoBase = peso;
            }
            else
            {
                CostoBase = peso / 2;
            }
            IVA = CostoBase * 1.21;
            CostoAPagar = CostoBase + IVA;
            Pagos[Contador] = CostoAPagar;
            Contador++;
        }
        public int CantidadDeCorrespondenciaPorEmpresa(int nroEmpresa)
        {
            int contador = 0;
            for(int i = 0; i < Contador; i++)
            {
                if (EmpresasDistribucion[i] == nroEmpresa)
                {
                    contador++;
                }
            }
            return contador;
        }
        public double RecaudacionPorEmpresa(int nroEmpresa)
        {
            double recaudado = 0;
            for (int i = 0; i < Contador; i++)
            {
                if (Pagos[i] == nroEmpresa)
                {
                    recaudado += Pagos[i];
                }
            }
            return recaudado;
        }
        public int CorrespondenciaPorEmpresa(int nroEmpresa)
        {

            return
        }
        public double RecaudacionTotal()
        {
            return
        }
        public int TransporteConMayorCorrespondencia()
        {
            return
        }
        public int[] PrepararDistribucionAEmpresa(int empresa,ref int cantidad)
        {
            return
        }
    }
}
