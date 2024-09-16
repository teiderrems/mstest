using Util;

namespace MsTest;

[TestClass]
public class FunctionTest
{
    [TestMethod]
    [DataRow(-1,DisplayName ="Test de la fonction factorielle")]
    [DataRow(-10,DisplayName ="Test de la fonction factorielle")]
    [DataRow(-15,DisplayName ="Test de la fonction factorielle")]
    [DataRow(-25,DisplayName ="Test de la fonction factorielle")]
    [DataRow(-35,DisplayName ="Test de la fonction factorielle")]
    [DataRow(-350,DisplayName ="Test de la fonction factorielle")]
    public void FactorielOfNegatifNumberIsNotExist(int value)
    {
        try
        {
            var result=UtilFunction.factoriel(value);
        }
        catch (System.Exception error)
        {
            
            Assert.AreEqual("Le factoriel d'un nombre négatif n'existe pas.", error.Message);
        }
    }

    [TestMethod]
    [DataRow(0,1,DisplayName ="Factoriel des nombres positifs")]
    [DataRow(1,1,DisplayName ="Factoriel des nombres positifs")]
    [DataRow(2,2,DisplayName ="Factoriel des nombres positifs")]
    [DataRow(3,6,DisplayName ="Factoriel des nombres positifs")]
    [DataRow(4,24,DisplayName ="Factoriel des nombres positifs")]
    public void FactorielOfPositifNumberIsPositifNumber(int input,int expert){
        var result=UtilFunction.factoriel(input);
        Assert.AreEqual(expert, result);
    }

    [TestMethod]
    [DataRow(-1,DisplayName = "Fibonacci nombre négatif")]
    [DataRow(-10,DisplayName = "Fibonacci nombre négatif")]
    [DataRow(-25,DisplayName = "Fibonacci nombre négatif")]
    [DataRow(-35,DisplayName = "Fibonacci nombre négatif")]
    [DataRow(-150,DisplayName = "Fibonacci nombre négatif")]
    [DataRow(-50,DisplayName = "Fibonacci nombre négatif")]
    public void FibonacciNegatifNumberNotExist(int value){
        try
        {
            var result = UtilFunction.fibonacci(value);
        }
        catch (System.Exception error)
        {
            Assert.AreEqual("La suite de fibonacci d'un nombre négatif n'existe pas", error.Message);
        }
    }

    [TestMethod]
    [DataRow(0,1,DisplayName ="Fibonacci des nombres positifs")]
    [DataRow(1,1,DisplayName ="Fibonacci des nombres positifs")]
    [DataRow(2,2,DisplayName ="Fibonacci des nombres positifs")]
    [DataRow(3,3,DisplayName ="Fibonacci des nombres positifs")]
    [DataRow(4,5,DisplayName ="Fibonacci des nombres positifs")]
    [DataRow(5,8,DisplayName ="Fibonacci des nombres positifs")]
    [DataRow(6,13,DisplayName ="Fibonacci des nombres positifs")]
    [DataRow(7,21,DisplayName ="Fibonacci des nombres positifs")]
    public void FibonacciOfPositifNumberIsArrayOfPositifNumber(int input,int expert){
        var result=UtilFunction.fibonacci(input);
        Assert.AreEqual(expert, result);
    }
}