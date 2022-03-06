using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveControlLibrary
{
    internal class MenuNode<T>
    {
        public T Data { get; set; } 
        public MenuNode<T> NodeParent { get; set; }
        public List<MenuNode<T>> NodeChildren { get; set; }
        public int GetHigh
        {
            get
            {
                int high = 1;
                MenuNode<T> currentNode = this;
                while (currentNode.NodeParent != null)
                {
                    high++;
                    currentNode = currentNode.NodeParent;
                }
                return high;
            }
        }
    }
}
