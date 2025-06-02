public class Solution {
    public bool IsValid(string s) {

        Stack<char> currStack = new Stack<char>();
        
        foreach(var c in s){
            if(c == '(' || c== '{' || c=='['){
                currStack.Push(c);
            }
            else{
                if(currStack.Count() == 0){
                   return false;
                }
                var prevChar = currStack.Peek();
                if(
                   ( c == ')' && prevChar =='(') ||
                   ( c == ']' && prevChar =='[') ||
                   ( c == '}' && prevChar =='{') 
                  )
                   {
                      currStack.Pop();
                   }
                 else{
                    return false;
                 }
            }

 
            
          
        }

        return currStack.Count() == 0? true: false;
    }
}