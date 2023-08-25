using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plantao_UC_COD_BACK.Classes
{
    public class PessoaJuridica : Pessoa
    {
        public string? Cnpj { get; set; }

        //método para inserir um objeto em arquivo txt
        public void Inserir(PessoaJuridica pj){
            using (StreamWriter sw = new StreamWriter($"banco.txt")){
                sw.WriteLine($"{pj.Nome},{pj.Rendimento},{pj.Cnpj}");
            }
        }
    }
}