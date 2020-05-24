using Codenation.Challenge;
using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;

namespace Source
{
    public class program
    {
        static void Main (string[] args){
            CesarCypher cc = new CesarCypher();
            string c = cc.Crypt("the quick brown fox jumps over the lazy dog 123");
            //string d = cc.Decrypt("wkh txlfn eurzq ira mxpsv ryhu wkh odcb grj");
            string a = null;
            cc.Crypt(a);

            //Console.WriteLine(c.Equals("wkh txlfn eurzq ira mxpsv ryhu wkh odcb grj"));
        }
    }
}