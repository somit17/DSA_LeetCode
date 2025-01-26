public class MyStack {
    Queue<int> q1;
    //Queue<int> q2;
    public MyStack() {
        q1=new Queue<int>();
        //q2=new Queue<int>();
    }
    
    public void Push(int x) {
        q1.Enqueue(x);
        
        for(int i=0;i<q1.Count-1;i++){
            q1.Enqueue(q1.Dequeue());
        }
    }
    
    public int Pop() {
       if(q1.Count>0)
       return q1.Dequeue(); 
       else return 0;
    }
    
    public int Top() {
        if(q1.Count>0) return q1.Peek();
        else return 0;
    }
    
    public bool Empty() {
        return q1.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */