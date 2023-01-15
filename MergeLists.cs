using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkLetsGo
{
    public class MergeLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode temp1 = list1;
            ListNode temp2 = list2;
            ListNode head = null;

            if (list1 == null && list2 == null) return null;
            if (list1 == null && list2 != null) return list2;
            if (list1 != null && list2 == null) return list1;

            while (temp1 != null && temp2 != null)
            {
                if (temp1.val > temp2.val)
                {
                    head = new ListNode(temp2.val, head);
                    temp2 = temp2.next;
                }
                else
                {
                    head = new ListNode(temp1.val, head);
                    temp1 = temp1.next;
                }
            }

            while (temp2 != null)
            {
                head = new ListNode(temp2.val, head);
                temp2 = temp2.next;
            }
            while (temp1 != null)
            {
                head = new ListNode(temp1.val, head);
                temp1 = temp1.next;
            }

            temp1 = null;
            temp2 = head;
            ListNode temp3 = null;
            while(temp2 != null)
            {
                temp3 = temp2.next;
                temp2.next = temp1;
                temp1 = temp2;
                temp2 = temp3;
            }
            head = temp1;
            return head;

            //ListNode prehead = new ListNode(-1); //2 способ нашел
            //ListNode cur = prehead;

            //while (l1 != null && l2 != null)
            //{
            //    if (l1.val <= l2.val)
            //    {
            //        cur.next = l1;
            //        l1 = l1.next;
            //    }
            //    else
            //    {
            //        cur.next = l2;
            //        l2 = l2.next;
            //    }
            //    cur = cur.next;
            //}

            //cur.next = l1 == null ? l2 : l1;
            //return prehead.next;
        }
    }
}
