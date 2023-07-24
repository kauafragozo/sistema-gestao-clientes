using System;
namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar o Nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar o Endereço");
            string var_endereço = Console.ReadLine();
            Console.WriteLine("Pessoa Fisica (f) ou Pessoa Juridica (j)?");
            string var_tipo = Console.ReadLine();
            if(var_tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica ();
                pf.nome = var_nome;
                pf.endereço = var_endereço;
                Console.WriteLine("Informar o CPF");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar o RG");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar Valor da Compra");
                val_pag = float.Parse(Console.ReadLine());
                pf.pagar_imposto(val_pag);
                Console.WriteLine("-----Pessoa Fisica-------");
                Console.WriteLine("Nome:......:" + pf.nome);
                Console.WriteLine("Endereço:......:" + pf.endereço);
                Console.WriteLine("CPF:......:" + pf.cpf);
                Console.WriteLine("RG:......:" + pf.rg);
                Console.WriteLine("Valor da Compra:........:" + pf.valor.ToString("C"));
                Console.WriteLine("Imposto:.......:" + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Valor Total:.......:" +pf.total.ToString("C"));
            }
            if(var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica ();
                pj.nome = var_nome;
                pj.endereço = var_endereço;
                Console.WriteLine("Informar o CNPJ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar o IE");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar o Valor da Compra");
                val_pag = float.Parse(Console.ReadLine());
                pj.pagar_imposto(val_pag);
                Console.WriteLine("----Pessoa Juridica----");
                Console.WriteLine("Nome....:" + pj.nome);
                Console.WriteLine("Endereço:...." + pj.endereço);
                Console.WriteLine("CNPJ:....." + pj.cnpj);
                Console.WriteLine("Ie:......" + pj.ie);
                Console.WriteLine("Valor da Compra:...." + pj.valor.ToString("C"));
                Console.WriteLine("Imposto:....." + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Valor Total:....." +pj.total.ToString("C"));
            }
        }
    }
}
