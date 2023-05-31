using LeetcodeExercises.Structures;

namespace LeetcodeExercises.Easy
{
    public static class MiddleOfTheLinkedList
    {
        public static ListNode MiddleNode(ListNode head)
        {
            if (head.next == null) return head;

            var helperNode = head;
            var numberOfNodes = 0;

            while (helperNode != null)
            {
                numberOfNodes++;
                helperNode = helperNode.next;
            }

            var atNode = 1;

            while (head != null)
            {
                if (atNode == (numberOfNodes / 2) + 1) return head;

                atNode++;
                head = head.next;
            }

            return head;
        }

        public static ListNode MiddleNodeTwoPointer(ListNode head)
        {
            if (head.next == null) return head;

            var helperNode = head.next;

            while (helperNode != null)
            {
                head = head.next;
                helperNode = helperNode.next;

                if (helperNode != null) helperNode = helperNode.next;
            }

            return head;
        }
    }
}
