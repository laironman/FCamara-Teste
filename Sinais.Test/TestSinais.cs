using NUnit.Framework;

namespace Sinais.Test
{
    [TestFixture]
    public class TestSinais
    {
        [Test]
        [TestCase("{[()]}", true)]
        [TestCase("{[(])}", false)]
        [TestCase("{{[[(())]]}}", true)]
        public void TestSinaisValida(string sequencia, bool resultado)
        {
            var sinal = new Sinal();
            // TODO: Add your test code here
            var retorno = sinal.Valida(sequencia);
            Assert.AreEqual(resultado,retorno);
        }
    }
}
