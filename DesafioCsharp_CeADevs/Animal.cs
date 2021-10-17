using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCsharp_CeADevs
{
    public abstract class Animal
    {
        private string nome;
        private string tipo;


        public virtual string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public virtual string getTipo()
        {
            if (tipo != "cachorro" && tipo != "gato" && tipo != "peixe")
            {
                tipo = "peixe";               
                return tipo;
            }
            else
            {
                
            }
            return this.tipo;


        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;

        }        
        

    }
}
