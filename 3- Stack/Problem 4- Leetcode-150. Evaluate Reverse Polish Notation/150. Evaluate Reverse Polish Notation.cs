public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> tokenStack = new();
        string[] operations = new string[]{"+","-","*","/"};
       
        foreach(var token in tokens){
            if( operations.Contains(token)){
                int a = tokenStack.Pop();
                int b = tokenStack.Pop();
                tokenStack.Push( (doOperation(b,a,token)) );
            }
            else{
                tokenStack.Push(Convert.ToInt32(token));
            }
        }
        return tokenStack.Pop();
    }
    public int doOperation(int a,int b,string operation){
        switch(operation){
            case "+":
               return a+b;
            case "-":
                 return a-b;
            case "*":
                  return a*b;
            default:
                 return a/b;
        }
    }
}