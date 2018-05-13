using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link
{
    class CirculationLinkList
    { 
        class Node
        {
            public object item;
            public CirculationLinkList.Node next;
            public override string ToString()
            {
                return item.ToString();
            }
            public Node(object v)
            {
                item = v;
                next = null;
            }
        }
        private int count;
        private Node tail;
        private Node curPreValue;

        public int Count { get { return count; } }

        public void Add(object value)
        {
            Node newNode = new Link.CirculationLinkList.Node(value);
            if (tail == null)
            {
                tail = newNode;
                tail.next = newNode;
                curPreValue = newNode;
            }
            else
            {
                newNode.next = tail.next;
                tail.next = newNode;
                if (curPreValue == tail)
                {
                    curPreValue = newNode;
                }
                tail = newNode;
                
            }
            count++;
        }

        public void RemoveCurrNode()
        {
            if (tail == null) return;
            else if ( count == 1)
            {
                tail = null;
                curPreValue = null;
            }
            else
            {
             
                curPreValue.next = curPreValue.next.next;
            }
            count--;
        }
        public void Move(int s)
        {
            for (int i = 0; i < s; i++)
            {
                curPreValue = curPreValue.next;
            }
        }
        public object Current
        {
            get
            {
                return curPreValue.next.item;
            }
        }
        public override string ToString()
        {
            if (tail == null) return string.Empty;
            string s = "";
            Node temp = tail.next;
            for (int i = 0; i < count; i++)
            {
                s += temp.ToString() + "   ";
                temp = temp.next;
            }
            return s;

        }
    }
}
