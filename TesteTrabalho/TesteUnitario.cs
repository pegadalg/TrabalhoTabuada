using TrabalhoTabuada;

namespace TesteTrabalho
{
    [TestClass]
    public class TesteTrabalho
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            float num1 = 2;
            float num2 = 3;
            var ClasseTrabalho = new ClasseTrabalho();

            float resultado = ClasseTrabalho.SomarDoisNumeros(num1, num2);

            Assert.AreEqual(5, resultado);
        }


        [TestMethod]
        public void Conversor()
        {
            float metros = 5;
            var ClasseTrabalho = new ClasseTrabalho();

            float resultado = ClasseTrabalho.Conversor(metros);

            Assert.AreEqual(5000, resultado);
        }

        [TestMethod]

        public void Tabuada()
        {
            var ClasseTrabalho = new ClasseTrabalho();
            string resultado = ClasseTrabalho.Tabuada();

            Assert.AreEqual("  1 x 1 = 1\n  1 x 2 = 2\n  1 x 3 = 3\n  1 x 4 = 4\n  1 x 5 = 5\n  1 x 6 = 6\n  1 x 7 = 7\n  1 x 8 = 8\n  1 x 9 = 9\n  1 x 10 = 10\n\n  2 x 1 = 2\n  2 x 2 = 4\n  2 x 3 = 6\n  2 x 4 = 8\n  2 x 5 = 10\n  2 x 6 = 12\n  2 x 7 = 14\n  2 x 8 = 16\n  2 x 9 = 18\n  2 x 10 = 20\n\n  3 x 1 = 3\n  3 x 2 = 6\n  3 x 3 = 9\n  3 x 4 = 12\n  3 x 5 = 15\n  3 x 6 = 18\n  3 x 7 = 21\n  3 x 8 = 24\n  3 x 9 = 27\n  3 x 10 = 30\n\n  4 x 1 = 4\n  4 x 2 = 8\n  4 x 3 = 12\n  4 x 4 = 16\n  4 x 5 = 20\n  4 x 6 = 24\n  4 x 7 = 28\n  4 x 8 = 32\n  4 x 9 = 36\n  4 x 10 = 40\n\n  5 x 1 = 5\n  5 x 2 = 10\n  5 x 3 = 15\n  5 x 4 = 20\n  5 x 5 = 25\n  5 x 6 = 30\n  5 x 7 = 35\n  5 x 8 = 40\n  5 x 9 = 45\n  5 x 10 = 50\n\n  6 x 1 = 6\n  6 x 2 = 12\n  6 x 3 = 18\n  6 x 4 = 24\n  6 x 5 = 30\n  6 x 6 = 36\n  6 x 7 = 42\n  6 x 8 = 48\n  6 x 9 = 54\n  6 x 10 = 60\n\n  7 x 1 = 7\n  7 x 2 = 14\n  7 x 3 = 21\n  7 x 4 = 28\n  7 x 5 = 35\n  7 x 6 = 42\n  7 x 7 = 49\n  7 x 8 = 56\n  7 x 9 = 63\n  7 x 10 = 70\n\n  8 x 1 = 8\n  8 x 2 = 16\n  8 x 3 = 24\n  8 x 4 = 32\n  8 x 5 = 40\n  8 x 6 = 48\n  8 x 7 = 56\n  8 x 8 = 64\n  8 x 9 = 72\n  8 x 10 = 80\n\n  9 x 1 = 9\n  9 x 2 = 18\n  9 x 3 = 27\n  9 x 4 = 36\n  9 x 5 = 45\n  9 x 6 = 54\n  9 x 7 = 63\n  9 x 8 = 72\n  9 x 9 = 81\n  9 x 10 = 90\n\n  10 x 1 = 10\n  10 x 2 = 20\n  10 x 3 = 30\n  10 x 4 = 40\n  10 x 5 = 50\n  10 x 6 = 60\n  10 x 7 = 70\n  10 x 8 = 80\n  10 x 9 = 90\n  10 x 10 = 100\n\n", resultado);
        }

        [TestMethod]

        public void TabuadaUnitaria()
        {
            int num = 0;
            var ClasseTrabalho = new ClasseTrabalho();

            string resultado = ClasseTrabalho.Tabuada(num);

            Assert.AreEqual("  0 x 0 = 0\n  0 x 1 = 0\n  0 x 2 = 0\n  0 x 3 = 0\n  0 x 4 = 0\n  0 x 5 = 0\n  0 x 6 = 0\n  0 x 7 = 0\n  0 x 8 = 0\n  0 x 9 = 0\n  0 x 10 = 0\n", resultado);


        }


    }
}