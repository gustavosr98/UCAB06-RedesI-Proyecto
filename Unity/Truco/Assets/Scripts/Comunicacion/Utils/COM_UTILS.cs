using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Text;

public static class COM_UTILS {

    public static string BinaryToHex(string binary){
        StringBuilder result = new StringBuilder(binary.Length / 8 + 1);
        // TODO: check all 1's or 0's... Will throw otherwise
        int mod4Len = binary.Length % 8;
        if (mod4Len != 0){
            // pad to length multiple of 8
            binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
        }

        for (int i = 0; i < binary.Length; i += 8){
            string eightBits = binary.Substring(i, 8);
            result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
        }

        return result.ToString();
    }

    public static string HexToBinary(string hexvalue){
        string binaryval = "";
        binaryval = Convert.ToString(Convert.ToInt32(hexvalue, 16), 2);
        return binaryval;
    }

    public static string BinaryToBase64(string binary){
        string aux = binary;
        string output = "";
        for( int i = 0; i < binary.Length ; i++ ){
            output = output + ByteToBase64( aux.Substring( i*8 , (i+1)*8 ) );
        }

        return output;
    }

    public static string ByteToBase64(string x){
        int aux = 0;
        for (int i = 0; i < x.Length; i++)
            aux = aux + int.Parse( x[ x.Length - i -1].ToString() )^i;

        return aux.ToString();
    }

    public static string Prueba(string x){
        byte[] data = { (byte) 0xB6, (byte) 0x79, (byte) 0xC0, (byte) 0xAF,
                (byte) 0x18, (byte) 0xF4, (byte) 0xE9, (byte) 0xC5,
                (byte) 0x87, (byte) 0xAB, (byte) 0x8E, (byte) 0x20,
                (byte) 0x0A, (byte) 0xCD, (byte) 0x4E, (byte) 0x48,
                (byte) 0xA9, (byte) 0x3F, (byte) 0x8C, (byte) 0xB6 };

        return Convert.ToBase64String(data);
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

        return null;
    }

    public static string EToString(string emisor)
    {
        if (emisor == "000")
            return "A";
        else if (emisor == "001")
            return "B";
        else if (emisor == "010")
            return "C";
        else if (emisor == "011")
            return "D";

        return null;
    }


    public static string Carta(string carta)
    {
        if (carta == "4C")
            return "000000";
        else if (carta == "4O")
            return "000001";
        else if (carta == "4B")
            return "000010";
        else if (carta == "4E")
            return "000011";
        else if (carta == "5C")
            return "000100";
        else if (carta == "5O")
            return "000101";
        else if (carta == "5B")
            return "000110";
        else if (carta == "5E")
            return "000111";
        else if (carta == "6C")
            return "001000";
        else if (carta == "6O")
            return "001001";
        else if (carta == "6B")
            return "001010";
        else if (carta == "6E")
            return "001011";
        else if (carta == "7C")
            return "001100";
        else if (carta == "7B")
            return "001110";
        else if (carta == "10C")
            return "010000";
        else if (carta == "10O")
            return "010001";
        else if (carta == "10B")
            return "010010";
        else if (carta == "10E")
            return "010011";
        else if (carta == "11C")
            return "010100";
        else if (carta == "11O")
            return "010101";
        else if (carta == "11B")
            return "010110";
        else if (carta == "11E")
            return "010111";
        else if (carta == "12C")
            return "011000";
        else if (carta == "12O")
            return "011001";
        else if (carta == "12B")
            return "011010";
        else if (carta == "12E")
            return "011011";
        else if (carta == "1C")
            return "011100";
        else if (carta == "1O")
            return "011101";
        else if (carta == "2C")
            return "100000";
        else if (carta == "2O")
            return "100001";
        else if (carta == "2B")
            return "100010";
        else if (carta == "2E")
            return "100011";
        else if (carta == "3C")
            return "100100";
        else if (carta == "3O")
            return "100101";
        else if (carta == "3B")
            return "100110";
        else if (carta == "3E")
            return "100111";
        else if (carta == "7O")
            return "101001";
        else if (carta == "7E")
            return "101111";
        else if (carta == "1B")
            return "110010";
        else if (carta == "1E")
            return "110111";
        else if (carta == "Perica")
            return "111000";
        else if (carta == "Perico")
            return "111100";

        return null;
    }

    public static string CartaToString(string carta)
    {
        if (carta == "000000")
            return "4C";
        else if (carta == "000001")
            return "4O";     
        else if (carta == "000010")
            return "4B";
        else if (carta == "000011")
            return "4E";
        else if (carta == "000100")
            return "5C";
        else if (carta == "000101")
            return "5O";
        else if (carta == "000110")
            return "5B";
        else if (carta == "000111")
            return "5E";
        else if (carta == "001000")
            return "6C";
        else if (carta == "001001")
            return "6O";
        else if (carta == "001010")
            return "6B";
        else if (carta == "001011")
            return "6E";
        else if (carta == "001100")
            return "7C";
        else if (carta == "001110")
            return "7B";
        else if (carta == "010000")
            return "10C";
        else if (carta == "010001")
            return "10O";
        else if (carta == "010010")
            return "10B";
        else if (carta == "010011")
            return "10E";
        else if (carta == "010100")
            return "11C";
        else if (carta == "010101")
            return "11O";
        else if (carta == "010110")
            return "11B";
        else if (carta == "010111")
            return "11E";
        else if (carta == "011000")
            return "12C";
        else if (carta == "011001")
            return "12O";
        else if (carta == "011010")
            return "12B";
        else if (carta == "011011")
            return "12E";
        else if (carta == "011100")
            return "1C";
        else if (carta == "011101")
            return "1O";
        else if (carta == "100000")
            return "2C";
        else if (carta == "100001")
            return "2O";
        else if (carta == "100010")
            return "2B";
        else if (carta == "100011")
            return "2E";
        else if (carta == "100100")
            return "3C";
        else if (carta == "100101")
            return "3O";
        else if (carta == "100110")
            return "3B";
        else if (carta == "100111")
            return "3E";
        else if (carta == "101001")
            return "7O";
        else if (carta == "101111")
            return "7E";
        else if (carta == "110010")
            return "1B";
        else if (carta == "110111")
            return "1E";
        else if (carta == "111000")
            return "Perica";
        else if (carta == "111100")
            return "Perico";

        return null;
    }

    public static string Equipo(string equipo){
        if ( equipo == "AC")
            return "0";
        else if ( equipo == "BD")
            return "1";

        return null;
    }

    public static string EquipoToString(string equipo)
    {
        if (equipo == "0")
            return "AC";
        else if (equipo == "1")
            return "BD";

        return null;
    }
    
    public static string Canto(string canto){
        if ( canto == "Truco")
            return "0";
        else if ( canto == "Envido")
            return "1";

        return null;
    }

    public static string CantoToString(string canto)
    {
        if (canto == "0")
            return "Truco";
        else if (canto == "1")
            return "Envido";

        return null;
    }

    // MENSAJES
    public static string c_JUGAR_CARTA = "11000001"; 
    public static string JUGAR_CARTA(string e, string carta){
        // TT(8) E(3) D(3) Carta(6)
        return string.Format("{0}{1}{2}{3}", 
            c_JUGAR_CARTA,
            E(e),
            "111",
            Carta(carta)
        );
    }

    public static string c_PEDIR_CANTO = "11000010"; 
    public static string PEDIR_CANTO(string e, string D, string equipo, string canto){
        // TT(8) E(3) D(3) Equipo(1) Canto(1)
        return string.Format("{0}{1}{2}{3}{4}", 
            c_PEDIR_CANTO,
            E(e),
            E(D),
            Equipo(equipo),
            Canto(canto)
        );
    }

    public static string c_RESPONDER_CANTO = "11000011"; 
    public static string RESPONDER_CANTO(string e, string D, string canto, bool resp){
        // TT(8) E(3) D(3) Equipo(1) Respuesta(1)
        return string.Format("{0}{1}{2}{3}{4}", 
            c_RESPONDER_CANTO,
            E(e),
            E(D),
            Canto(canto),
            resp ? "1" : "0"
        );
    }

    public static string c_REPARTIENDO_CARTAS = "11000100"; 
    public static string REPARTIENDO_CARTAS(string D, string carta1, string carta2, string carta3){
        // TT(8) E(3) D(3) C1(6), C2, C3 == 32
        return string.Format("{0}{1}{2}{3}{4}{5}", 
            c_REPARTIENDO_CARTAS,
            E("A"),
            E(D),
            Carta(carta1),
            Carta(carta2),
            Carta(carta3)
        );
    }

    public static string c_ELLOS_TIENEN_FLOR = "11000101"; 
    public static string ELLOS_TIENEN_FLOR(bool florA, bool florB, bool florC, bool florD){
        // TT(8) E(3) D(3) FlorA(1), FlorB, FlorC, FlorD = 18
        return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}",
            c_ELLOS_TIENEN_FLOR,
            E("A"),
            "111",
            florA ? "1" : "0",
            florB ? "1" : "0",
            florC ? "1" : "0",
            florD ? "1" : "0",
            "00000000000000"
        );
    }

    public static string c_VIRA = "11000110";
    public static string VIRA(string vira)
    {
        // TT(8) E(3) D(3) Vira(6) = 20
        return string.Format("{0}{1}{2}{3}{4}",
            c_VIRA,
            E("A"),
            "111",
            Carta(vira),
            "000000000000"
        );
    }
}