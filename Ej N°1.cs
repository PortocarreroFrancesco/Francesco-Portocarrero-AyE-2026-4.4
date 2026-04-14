static string ejercicio1(int n){
    if (n > 0){
        string res = "es positivo";
        return res;
    }
    else if (n<0)
    {
        string res = "es negativo";
        return res;
    }
    else
    {
        string res = "es 0";
        return res;
    }

}

Console.WriteLine(ejercicio1(Convert.ToInt32(Console.ReadLine())));
