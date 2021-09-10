using ADO;

namespace Modelo
{
    public struct Conexion
    {
        private static EntidadesBanquetera entidades;

        public static EntidadesBanquetera Entidades
        {
            get 
            { 
                if (entidades == null)
                {
                    entidades = new EntidadesBanquetera();
                }
                return entidades; 
            }
        }

    }
}
