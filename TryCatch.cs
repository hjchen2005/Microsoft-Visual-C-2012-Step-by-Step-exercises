/*Write your code inside a try block (try is a C# keyword). When the code runs, it attempts to
execute all the statements inside the try block, and if none of the statements generates an
exception, they all run, one after the other, to completion */

using System;
//using System.Windows.Forms;

namespace ErrMgmt{
    public class TryCatch{
    public static void Main(string args[]){
        string result;
        try{
            int lhs=int.Parse(lhsOperand.Text);
            int rhs=int.Parse(rhsOperand.Text);
            int answer=lhs-rhs;
            result.Text = answer.ToString();
        }catch (FormatException fEx){
           /* DialogueResult res = MessageBox.Show("Format Exception");
            if (res == System.Windows.Forms.DialogueResult.Yes){
                this.close();
            }*/
            //Message property contains a text description of the error that caused the exception.
            result=fEx.Message;
            Console.WriteLine("Error: ",result); 
            Console.WriteLine("If you need any assistance, visit ",fEx.HelpLink);
        }
    }
}
    
}
