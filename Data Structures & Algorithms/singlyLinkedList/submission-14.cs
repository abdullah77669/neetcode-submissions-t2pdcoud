public class Node
{
    public int data;
    public Node next;

    public Node(int val)
    {
        data=val;
        next=null;        
    }
}
public class LinkedList {
   
    Node head;
    public LinkedList() {
         head=null;
         
    }

    public int Get(int index) {
       if(index==0)
      {
        if(head==null)
        return -1;
         return head.data;
      }
       Node temp=head;
       for(int i=0;i<index;i++)
       {
        if(temp==null )
        return -1;
        
        temp=temp.next;
        
       }
       if(temp==null)
       return -1;

       return temp.data;
    }

    public void InsertHead(int val) {
        Node newNode=new Node(val);
        if(head==null)
        {
            head=newNode;
        }
        else
        {
            newNode.next=head;
            head=newNode;
        }
       

    }

    public void InsertTail(int val) {
         
        Node newNode=new Node(val);
        if(head==null)
        {
            head=newNode;

        }
        else
        {   Node temp=head;
            while(temp.next != null)
            {
                temp=temp.next;
            }
            temp.next=newNode;
        }
    }

    public bool Remove(int index) {
        if(head==null)
        return false;
        if(index==0)
        {
            head=head.next;
            return true;
        }
        else
        {
            Node temp=head;
            int count=0;
            while(count!=index-1)
            {
                if(temp==null || temp.next==null)
                return false;
                temp=temp.next;
                count++;
            }
            
            if(temp.next==null)
            return false;
         
            temp.next=temp.next.next;            
            return true;
        }      

    }

    public List<int> GetValues() {
        Node temp = head;
        List<int> list = new List<int>();
        while(temp!=null)
        {
            list.Add(temp.data);
            temp=temp.next;
        }
        return list;
    }
}