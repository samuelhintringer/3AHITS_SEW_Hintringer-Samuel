using System.IO;
class Program
{
    static void Main(string[] args)
    {
        
    }

    static bool isPrim(int n)
    {
        int[] arr = {2,3,5,7};
        for(int i = 0; i < arr.Length; i++){
            if(n == arr[i]){
                return true;
            }
            else if(n % arr[i] == 0){
                return false;
            }
        }
        int primCount = 0;
        string str1;
        for(int i = 0; i < 10000; i++){
            if(isPrim(i)){
                primCount++;
            }
            str1 = $"{i} - {isPrim(i)} \n";
            if(i == 0){
                File.WriteAllText("./PrimeNumbers.tx", str1);
            }
            else
            {
                File.AppendAllText("./PrimeNumbers.tx", str1);
            }
        }
        File.AppendAllText("./PrimeNumbers.tx", primCount.ToString());
        return true;
    }
}
