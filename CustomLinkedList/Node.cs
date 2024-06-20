using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
   public class Node <Link>
    {
        //Data
        public Link Data {  get; set; }

        //link
        public Node <Link> Next { get; set; }

        // constructor
        public Node (Link data)
        {
            this.Data = data;
        }

    }
}
