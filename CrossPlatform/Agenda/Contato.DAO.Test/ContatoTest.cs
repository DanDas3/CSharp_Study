using System;
using System.Collections.Generic;
using NUnit.Framework;
using Agenda.Domain;

namespace Agenda.DAO.Test
{
    [TestFixture]
    public class ContatoTest : BaseTest
    {
        Contatos contatos;

        [SetUp]
        public void Setup()
        {
            contatos = new Contatos();
        }

        [Test]
        public void InserirTest()
        {
            // Monta
            Contato contato = new Contato()
            {
                Id = Guid.NewGuid(),
                Nome = "Teste Ubuntu 2"
            };
            // Executa
            int ret = contatos.Inserir(contato);
            // Verifica
            Assert.Greater(ret, 0);
        }

        [Test]
        public void ObterTest()
        {
            //string id = "4D7A6C9C-4FF4-49F2-9E13-FA1145A4B270";
            //string nome = "Danilo";
            //id = Guid.NewGuid().ToString();
            Contato contato = new Contato()
            {
                Id = Guid.NewGuid(),
                Nome = "Mariana"
            };
            Contato contatoRetornado = new Contato();
            contatos.Inserir(contato);
            contatoRetornado = contatos.Obter(contato.Id.ToString());

            Assert.AreEqual(contato.Id, contatoRetornado.Id);
            Assert.AreEqual(contato.Nome, contatoRetornado.Nome);
        }

        [Test]
        public void ListarTest()
        {
            List<Contato> listaContatos = new List<Contato>();
            listaContatos = contatos.Listar();
            Assert.Greater(listaContatos.Count, 0);
        }

        [TearDown]
        public void TearDown()
        {
            contatos = null;
        }
    }
}
