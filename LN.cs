using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkLetsGo
{
    class LN
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode temp1;
            ListNode temp2;

            ListNode head = null; //ЛистНод который будет формироваться из суммы
            temp1 = l1;
            temp2 = l2;
            int carry = 0;
            while (temp1 != null && temp2 != null) //пока оба нода не налл выполняем сложение, формируем промежуточный нод и присваеваем его head, далее head будет иметь ссылку на себя предыдущего и тд
            {
                ListNode node;
                int sum = temp1.val + temp2.val;
                if ((sum + carry) / 10 == 0)
                {
                    node = new ListNode(sum + carry, head);
                    carry = 0;
                }
                else
                {
                    node = new ListNode((sum + carry) % 10, head);
                    carry = 1;
                }
                head = node;
                temp1 = temp1.next;
                temp2 = temp2.next;
            }
            while (temp1 != null) //если какойто из нодов прошел до конца не одновременно с другим, досчитываем его результат отдельно
            {
                ListNode node = head;
                if ((temp1.val + carry) / 10 == 0)
                {
                    node = new ListNode(temp1.val + carry, head);
                    carry = 0;
                }
                else
                {
                    node = new ListNode((temp1.val + carry) % 10, head);
                    carry = 1;
                }
                head = node;
                temp1 = temp1.next;

            }
            while (temp2 != null)
            {
                ListNode node = head;
                if ((temp2.val + carry) / 10 == 0)
                {
                    node = new ListNode(temp2.val + carry, head);
                    carry = 0;
                }
                else
                {
                    node = new ListNode((temp2.val + carry) % 10, head);
                    carry = 1;
                }
                head = node;
                temp2 = temp2.next;

            }
            if (carry == 1) //если осталась переносная еденица, формируем из нее последний нод
            {
                ListNode node = new ListNode(carry, head);
                head = node;
            }

            temp1 = null;
            temp2 = head;
            ListNode temp3 = null;
            while (temp2 != null) // переворачиваем ЛистНод
            {
                temp3 = temp2.next;
                temp2.next = temp1;
                temp1 = temp2;
                temp2 = temp3;
            }
            head = temp1;
            return head;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
