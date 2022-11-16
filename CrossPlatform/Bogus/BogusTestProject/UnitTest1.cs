using Bogus;
using BogusFrame;
using BogusFrame.Classes;
using BogusFrame.Regras;
namespace BogusTestProject
{
    public class Tests
    {
        private Manutencao manutencao;
        private Faker<ClassB> fake;
        private Faker<ClassA> fakeA;
        [SetUp]
        public void Setup()
        {
            manutencao = new Manutencao();
            fakeA = new Faker<ClassA>()
                .RuleFor(f => f.PropA, d => d.Lorem.Word())
                .RuleFor(f => f.PropB, d => d.Random.String2(5,"0-9").ToString())
                .RuleFor(f => f.PropC, d => d.Random.Int())
                .RuleFor(f => f.PropD, d => DateTime.Parse(d.Date.Recent().ToString("yyyy-MM-dd")));

            fake = new Faker<ClassB>("en")
                .RuleFor(f => f.PropE, d => d.Rant.Locale)
                .RuleFor(f => f.PropF, fakeA.Generate(3));
        }

        [Test]
        public void Test1()
        {
            var result = manutencao.Test1(fake.Generate());
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("")]
        public void Test2(string chars)
        {
            var dado = fake.Generate();
            dado.PropE = chars;

            Assert.That(() => manutencao.Test1(dado), Throws.Exception);
        }

        [TearDown]
        public void TearDown()
        {
            manutencao = null;
            fake = null;
            fakeA = null;
        }
    }
}