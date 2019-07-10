using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta {
    public string pinta;
    public int numero;

    public Carta(string pinta, int numero){
        this.pinta = pinta;
        this.numero = numero;

    }

    public static void prueba(){
        for(int i = 1; i < 13 ; i++)
            for(int p1 = 1; p1 < 5; p1++)
                for(int j = 1; j < 13 ; j++)
                    for(int p2 = 1; p2 < 5; p2++)
                        for(int v = 1; v < 5; v++)
                            if ( (i <= 7 && j <= 7 )|| (i >= 10 && j >= 10))
                                Debug.Log("duelo(" +i+ "," +(p1 == 1 ? "E" : p1 == 2 ? "B" : p1 == 3 ? "O" : "C")+ "," +j+ "," +(p2 == 1 ? "E" : p2 == 2 ? "B" : p2 == 3 ? "O" : "C")+ "," +( v == 1 ? "E" : v == 2 ? "B" : v == 3 ? "O" : "C")+") -> " + 
                                    Carta.duelo(
                                        i,
                                        p1 == 1 ? "E" : p1 == 2 ? "B" : p1 == 3 ? "O" : "C" ,
                                        j,
                                        p2 == 1 ? "E" : p2 == 2 ? "B" : p2 == 3 ? "O" : "C" ,
                                        v == 1 ? "E" : v == 2 ? "B" : v == 3 ? "O" : "C"  
                                ));

    }

    public static void prueba2(){
        for(int i = 1; i < 13 ; i++)
            for(int p1 = 1; p1 < 5; p1++)
                for(int j = 1; j < 13 ; j++)
                    for(int p2 = 1; p2 < 5; p2++)
                        for(int k = 1; k < 13 ; k++)
                            for(int p3 = 1; p3 < 5; p3++)
                                for(int v = 1; v < 5; v++)
                                
                                    if ( (i <= 7 && j <= 7 && k <= 7)|| (i >= 10 && j >= 10 && k >= 10))
                                        Debug.Log("valorEnvido(" +i+ "," +(p1 == 1 ? "E" : p1 == 2 ? "B" : p1 == 3 ? "O" : "C")+ "," +j+ "," +(p2 == 1 ? "E" : p2 == 2 ? "B" : p2 == 3 ? "O" : "C")+ ","  +k+ "," +(p3 == 1 ? "E" : p3 == 2 ? "B" : p3 == 3 ? "O" : "C")+ "," +( v == 1 ? "E" : v == 2 ? "B" : v == 3 ? "O" : "C")+") -> " + 
                                            Carta.valorEnvido(
                                                i,
                                                p1 == 1 ? "E" : p1 == 2 ? "B" : p1 == 3 ? "O" : "C" ,
                                                j,
                                                p2 == 1 ? "E" : p2 == 2 ? "B" : p2 == 3 ? "O" : "C" ,
                                                k,
                                                p3 == 1 ? "E" : p3 == 2 ? "B" : p3 == 3 ? "O" : "C" ,
                                                v == 1 ? "E" : v == 2 ? "B" : v == 3 ? "O" : "C"  
                                        ));

    }

    public static int valorCarta(int numero, string pinta, string vira ){
        if ( numero == 4 ){
            return 1;            
        }
        else if( numero == 5){
            return 2;
        }
        else if(numero == 6){
            return 3;
        }
        else if(numero==7 && pinta == "C"){
            return 4;
        }
        else if (numero == 7 && pinta == "B"){
            return 4;
        }

        else if(numero == 10 &&  pinta != vira ){
            return 5; 
        }
        else if (numero == 11 && pinta != vira){
            return 5;
        }
        else if (numero == 12 && pinta != vira){
            return 5;
        }
        else if(numero == 1  &&  pinta =="O"){
            return 6;
        }
        else if(numero ==1 && pinta == "C"){
            return 6;
        }
        else if (numero == 2){
            return 7;
        }
        else if (numero == 3){
            return 8;
        }
        else if (numero == 7 && pinta =="O"){
            return 9;
        }
        else if (numero == 7 && pinta =="E"){
            return 10;
        }
        else if (numero == 1 && pinta =="B"){
            return 11;
        }
        else if (numero == 1 && pinta =="E"){
            return 12;
        }
        else if (numero == 10 && pinta == vira){
            return 13;
        }
        else if (numero == 11 && pinta == vira){
            return 14;
        }
        
        return 0;
    }

    public static int duelo (int numero1, string pinta1, int numero2, string pinta2, string vira ){
            if(Carta.valorCarta(numero1,pinta1,vira) > Carta.valorCarta(numero2,pinta2,vira)){
                return -1;
            }
            else if (Carta.valorCarta(numero1,pinta1,vira) < Carta.valorCarta(numero2,pinta2,vira)){
                return 1;
            }
            else if (Carta.valorCarta(numero1,pinta1,vira) == Carta.valorCarta(numero2,pinta2,vira)){
                return 0;
            }
        return 0;
    }

    public static int valorEnvido(int numero1, string pinta1, int numero2, string pinta2,int numero3, string pinta3, string vira){
        
        if (pinta1 == pinta2 && pinta2 == pinta3){
            return -1;
        }

        if(pinta1 == pinta2 ){
            return 20+numero1+numero2;
        }
        else if(pinta1 == pinta3){
            return 20+numero1+numero3;
        }
        else if(pinta2 == pinta3 ){
            return 20+numero2+numero3;
        }
        else if (numero1 == 11 && pinta1 == vira && pinta2 == pinta1){
            return 30+numero2;
        }
        else if (numero1 == 11 && pinta1 == vira && pinta3 == pinta1 ){
            return 30+numero3;
        }
        else if (numero2 == 11 && pinta2 == vira && pinta1 == pinta2){
            return 30+numero1;
        }
        else if (numero2 == 11 &&pinta2 == vira && pinta3 == pinta2){
            return 30+numero3;
        }
        else if (numero3 == 11 && pinta3 == vira && pinta1== pinta3){
            return 30+numero1;
        }
        else if (numero3 == 11 && pinta3 == vira && pinta2 == pinta3){
            return 30+numero2;
        }
        else if (numero1 == 10 && pinta1 == vira && pinta2 == pinta1){
            return 30+numero2;
        }
        else if (numero1 == 10 && pinta1 == vira && pinta3 == pinta1 ){
            return 30+numero3;
        }
        else if (numero2 == 10 && pinta2 == vira && pinta1 == pinta2){
            return 30+numero1;
        }
        else if (numero2 == 10 && pinta2 == vira && pinta3 == pinta2){
            return 30+numero3;
        }
        else if (numero3 == 10 && pinta3 == vira && pinta1== pinta3){
            return 30+numero1;
        }
        else if (numero3 == 10 && pinta3 == vira && pinta2 == pinta3){
            return 30+numero2;
        }

        return 0;
    }
    
    public static int envido(int numero1, string pinta1, 
                            int numero2, string pinta2,
                            int numero3, string pinta3,
                            int numero4, string pinta4, 
                            int numero5, string pinta5,
                            int numero6, string pinta6, string vira
    ){
        if( 
            Carta.valorEnvido(numero1,pinta1,numero2,pinta2,numero3,pinta3,vira) > 
            Carta.valorEnvido(numero4,pinta4,numero5,pinta5,numero6,pinta6,vira) 
        ){
            return -1;
        }
        else if (
                Carta.valorEnvido(numero1,pinta1,numero2,pinta2,numero3,pinta3,vira) 
                < Carta.valorEnvido(numero4,pinta4,numero5,pinta5,numero6,pinta6,vira)
        ){
            return 1;
        }
        else if (
            Carta.valorEnvido(numero1,pinta1,numero2,pinta2,numero3,pinta3,vira) 
                == Carta.valorEnvido(numero4,pinta4,numero5,pinta5,numero6,pinta6,vira)
        ){
            return 0;
        }
        
        return 0;
    }

}