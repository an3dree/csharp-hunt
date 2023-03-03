using System;
using modificadores;
using racas;

namespace habilidades
{
    public class Habilidades
    {
        //string raca;
        static public int[] askHab(int forca, int inteli, int constituicao, int sabedoria, int carisma, int destreza){
            
            int[] inputHabilidades = {forca, inteli, constituicao, sabedoria, carisma, destreza};
            int[] modHabilidades = {
                                Modificadores.showMod(forca),
                                Modificadores.showMod(inteli),
                                Modificadores.showMod(constituicao),
                                Modificadores.showMod(sabedoria),
                                Modificadores.showMod(carisma),
                                Modificadores.showMod(destreza)
                            };
            
            switch(Racas.consus()){
                case "Anão":
                inputHabilidades[2] = inputHabilidades[2] +2;
                inputHabilidades[4] = inputHabilidades[4] -2;
                modHabilidades[2] = modHabilidades[2] +2;
                modHabilidades[4] = modHabilidades[4] -2;
                break;
                case "Humano":
                modHabilidades[0] = modHabilidades[0];
                modHabilidades[1] = modHabilidades[1];
                modHabilidades[2] = modHabilidades[2];
                modHabilidades[3] = modHabilidades[3];
                modHabilidades[4] = modHabilidades[4];
                modHabilidades[5] = modHabilidades[5];
                break;
                case "Elfo":
                inputHabilidades[2] = inputHabilidades[2] -2;
                inputHabilidades[3] = inputHabilidades[3] +2;
                modHabilidades[2] = modHabilidades[2] -2;  
                modHabilidades[3] = modHabilidades[3] +2;
                break;
                case "Halfling":
                inputHabilidades[2] = inputHabilidades[2] -2;
                inputHabilidades[5] = inputHabilidades[5] +2;
                modHabilidades[2] = modHabilidades[2] -2;  
                modHabilidades[5] = modHabilidades[5] +2;
                break;
                case "Orc":
                inputHabilidades[5] = inputHabilidades[5] -2;
                inputHabilidades[0] = inputHabilidades[0] +2;
                modHabilidades[5] = modHabilidades[5] -2;  
                modHabilidades[0] = modHabilidades[0] +2;
                break;
            }
            
            Console.WriteLine(Racas.consus());
            Console.WriteLine($"Força: {inputHabilidades[0]} Mod: {modHabilidades[0]}");
            Console.WriteLine($"Inteligência: {inputHabilidades[1]} Mod: {modHabilidades[1]}");
            Console.WriteLine($"Constituição: {inputHabilidades[2]} Mod: {modHabilidades[2]}");
            Console.WriteLine($"Sabedoria: {inputHabilidades[3]} Mod: {modHabilidades[3]}");
            Console.WriteLine($"Carisma: {inputHabilidades[4]} Mod: {modHabilidades[4]}");
            Console.WriteLine($"Destreza: {inputHabilidades[5]} Mod: {modHabilidades[5]}");
            
            return modHabilidades;
        }
    }
}