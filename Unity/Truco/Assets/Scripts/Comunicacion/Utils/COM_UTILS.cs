using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Text;

public static class COM_UTILS {
    
    public static string StringToBinary(string data){
        StringBuilder sb = new StringBuilder();
        foreach (char c in data.ToCharArray()){
            sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
        }
        return sb.ToString();
    }

    public static string BinaryToString(string data){
        List<Byte> byteList = new List<Byte>();
        for (int i = 0; i < data.Length; i += 8){
            byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
        }
        return Encoding.ASCII.GetString(byteList.ToArray());
    }

    // ATRIBUTOS EN MENSAJES
    public static string E(string emisor){
        if ( emisor == "A")
            return "000";
        else if ( emisor == "B")
            return "001";
        else if ( emisor == "C")
            return "010";
        else if ( emisor == "D")
            return "011";
    }

    public static string Carta(string carta){
        if (carta == "4C")
            return "OOOOOO"; 
        else if (carta == "4O")
            return "OOOOO1"; 
        else if (carta == "4B")
            return "OOOO1O"; 
        else if (carta == "4E")
            return "OOOO11"; 
        else if (carta == "5C")
            return "OOO1OO"; 
        else if (carta == "5O")
            return "OOO1O1"; 
        else if (carta == "5B")
            return "OOO11O"; 
        else if (carta == "5E")
            return "OOO111"; 
        else if (carta == "6C")
            return "OO1OOO"; 
        else if (carta == "6O")
            return "OO1OO1"; 
        else if (carta == "6B")
            return "OO1O1O"; 
        else if (carta == "6E")
            return "OO1O11"; 
        else if (carta == "7C")
            return "OO11OO"; 
        else if (carta == "7B")
            return "OO111O"; 
        else if (carta == "10C")
            return "O1OOOO"; 
        else if (carta == "10O")
            return "O1OOO1"; 
        else if (carta == "10B")
            return "O1OO1O"; 
        else if (carta == "10E")
            return "O1OO11"; 
        else if (carta == "11C")
            return "O1O1OO"; 
        else if (carta == "11O")
            return "O1O1O1"; 
        else if (carta == "11B")
            return "O1O11O"; 
        else if (carta == "11E")
            return "O1O111"; 
        else if (carta == "12C")
            return "O11OOO"; 
        else if (carta == "12O")
            return "O11OO1"; 
        else if (carta == "12B")
            return "O11O1O"; 
        else if (carta == "12E")
            return "O11O11";
        else if (carta == "1C") 
            return "O111OO"; 
        else if (carta == "1O") 
            return "O111O1"; 
        else if (carta == "2C") 
            return "1OOOOO"; 
        else if (carta == "2O") 
            return "1OOOO1"; 
        else if (carta == "2B") 
            return "1OOO1O"; 
        else if (carta == "2E") 
            return "1OOO11"; 
        else if (carta == "3C") 
            return "1OO1OO"; 
        else if (carta == "3O") 
            return "1OO1O1"; 
        else if (carta == "3B") 
            return "1OO11O"; 
        else if (carta == "3E") 
            return "1OO111"; 
        else if (carta == "7O") 
            return "1O1OO1"; 
        else if (carta == "7E") 
            return "1O1111"; 
        else if (carta == "1B") 
            return "11OO1O"; 
        else if (carta == "1E") 
            return "11O111";
        else if (carta == "Perica") 
            return "111OOO"; 
        else if (carta == "Perico") 
            return "1111OO";

    }

    public static string Equipo(string equipo){
        if ( equipo == "AC")
            return "0";
        else if ( equipo == "BD")
            return "1";
    }
    
    public static string Canto(string canto){
        if ( canto == "Truco")
            return "0";
        else if ( canto == "Envido")
            return "1";
    }

    // MENSAJES
    public static string JUGAR_CARTA = "00000001"; 
    public static string JUGAR_CARTA(string E, string carta, ){
        // TT(8) E(3) D(3) Carta(6)
        return string.Format("{0}{1}{2}{3}", 
            JUGAR_CARTA,
            E(E),
            "111",
            Carta(carta)
        );
    }

    public static string PEDIR_CANTO = "00000010"; 
    public static string PEDIR_CANTO(string E, string D, string equipo, string canto){
        // TT(8) E(3) D(3) Equipo(1) Canto(1)
        return string.Format("{0}{1}{2}{3}{4}", 
            PEDIR_CANTO,
            E(E),
            E(D),
            Equipo(equipo),
            Canto(canto)
        );
    }

    public static string RESPONDER_CANTO = "00000011"; 
    public static string RESPONDER_CANTO(string E, string D, string canto, bool resp){
        // TT(8) E(3) D(3) Equipo(1) Respuesta(1)
        return string.Format("{0}{1}{2}{3}{4}", 
            RESPONDER_CANTO,
            E(E),
            E(D),
            Canto(canto),
            resp ? "1" : "0"
        );
    }

    public static string REPARTIENDO_CARTAS = "00000100"; 
    public static string REPARTIENDO_CARTAS(string D, string carta1, string carta2, string carta3, string vira){
        // TT(8) E(3) D(3) C1(6), C2, C3, Vira
        return string.Format("{0}{1}{2}{3}{4}{5}{6}", 
            REPARTIENDO_CARTAS,
            E("A"),
            E(D),
            Carta(carta1),
            Carta(carta2),
            Carta(carta3),
            Carta(vira)
        );
    }

    public static string ELLOS_TIENEN_FLOR = "00000101"; 
    public static string ELLOS_TIENEN_FLOR(bool florA, bool florB, bool florC, bool florD){
        // TT(8) E(3) D(3) FlorA(1), FlorB, FlorC, FlorD
        return string.Format("{0}{1}{2}{3}{4}{5}{6}", 
            REPARTIENDO_CARTAS,
            E("A"),
            "111",
            florA ? "1" : "0",
            florB ? "1" : "0",
            florC ? "1" : "0",
            florD ? "1" : "0"
        );
    }

    



    
}