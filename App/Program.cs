using Dominio;
using Infraestrutura;
using System;


namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            int Id;
            var sessionFactory = Conexao.Criar();

            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var dep1 = new Dominio.Departamento
                    {
                        Nome = "Diretoria",
                        Descricao = "Departamento diretoria",
                        DataCadastro = DateTime.Now
                    };
                    session.Save(dep1);

                    var dep2 = new Dominio.Departamento
                    {
                        Nome = "Comercial",
                        Descricao = "Departamento comercial",
                        DataCadastro = DateTime.Now
                    };
                    session.Save(dep2);

                    var grp1 = new Dominio.Grupo
                    {
                        Nome = "Grupo 1",
                        Descricao = "Descrição do Grupo1",
                        DataCadastro = DateTime.Now
                    };
                    session.Save(grp1);

                    var grp2 = new Dominio.Grupo
                    {
                        Nome = "Grupo 2",
                        Descricao = "Descrição do Grupo 2",
                        DataCadastro = DateTime.Now
                    };
                    session.Save(grp2);

                    var pf = new Dominio.PessoaFisica
                    {
                        Nome = "Nome da pessoa fisica",
                        Endereco = "Endereço da pessoa fisica",
                        Cep = "12345678",
                        Email = "pessoa1@gmail.com",
                        DataCadastro = DateTime.Now,
                        Cpf = "12345678900",
                        Nacionalidade = "Brasil",
                        Departamento = dep1,
                        Status = Status.Inativo
                    };

                    session.Save(pf);

                    var pj = new Dominio.PessoaJuridica
                    {
                        Nome = "Nome da pessoa juridica",
                        Endereco = "Endereço da pessoa juridica",
                        Cep = "12345678",
                        Email = "pessoa1@gmail.com",
                        DataCadastro = DateTime.Now,
                        Cnpj = "12345678901234",
                        WebSite = "www.pessoajuridica.com.br",
                        Departamento = dep1,
                        Status = Status.Inativo
                    };
                    session.Save(pj);

                    var novaPf = new Dominio.PessoaFisica
                    {
                        Nome = "VAI EXCLUIR",
                        Endereco = "Endereço da pessoa fisica com telefone",
                        Cep = "12345678",
                        Email = "pessoa1@gmail.com",
                        DataCadastro = DateTime.Now,
                        Cpf = "12345678900",
                        Nacionalidade = "Brasil",
                        Departamento = session.Get<Dominio.Departamento>(2),
                        Status = Status.Inativo
                    };
                    novaPf.AdicionarGrupo(session.Get<Dominio.Grupo>(1));
                    novaPf.AdicionarGrupo(session.Get<Dominio.Grupo>(2));
                    novaPf.AdicionarTelefone(new Dominio.Telefone { CodigoDDD = 41, Numero = 123456 });
                    novaPf.AdicionarTelefone(new Dominio.Telefone() { CodigoDDD = 21, Numero = 654321 });
                    session.SaveOrUpdate(novaPf);

                    Id = novaPf.Id;

                    transaction.Commit();

                }

            }

            //using (var session = sessionFactory.OpenSession())
            //{
            //    using (var transaction = session.BeginTransaction())
            //    {
            //        var pf = session.Get<Dominio.PessoaFisica>(ID);
            //        session.Delete(pf);
            //        transaction.Commit();
            //    }
            //}
        }
    }
}
