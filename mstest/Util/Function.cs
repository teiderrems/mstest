namespace Util;

public class UtilFunction
{
    
    public static int factoriel(int value)
    {
        if (value < 0){
            throw new Exception("Le factoriel d'un nombre négatif n'existe pas.");
        }
        if (value==0 || value==1)
        {
            return 1;
        }
        return value*factoriel(value-1);
    }

    public static int fibonacci(int value){
        if (value < 0){
            throw new Exception("La suite de fibonacci d'un nombre négatif n'existe pas");
        }
        if (value==0 || value == 1)
        {
            return 1;
        }
        return fibonacci(value-1)+fibonacci(value-2);
    }
}
