namespace modificadores
{
    public class Modificadores
    {
        static public int showMod(int valorHab){

            int mod;
            int gMod;

            if(valorHab == 10){
                mod = 0;
                return mod;
            }
            else {
                gMod = valorHab - 10;
                mod = gMod/2;
                return mod;
            }
            
            //return mod;
        }
    }
}