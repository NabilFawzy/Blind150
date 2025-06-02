public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> pathStack = new();
        string[] segments = path.Split("/", StringSplitOptions.RemoveEmptyEntries);
        foreach(var segment in  segments){
            if(segment == "."){
                continue;
            }
            else if(segment == ".."){
                if(pathStack.Count()>0) pathStack.Pop();
            }
            else{
                pathStack.Push(segment);
            }
        }

        return "/"+String.Join("/",pathStack.Reverse());
    }
}