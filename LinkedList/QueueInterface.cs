using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core {
	public interface QueueInterface {
		bool isEmpty();
		//Pre: none
		//Post: Returns true if the queue is empty, otherwise returns false.
		void enqueue(IComparable item);
		//Pre:item is the new item to be added
		//Post: If insertion is successful, item is at the end of the queue.
		//Post:Throw QueueException if the item cannot be added to the queue.
		IComparable front();
		//Pre: none
		//Post: If queue is not empty, the item at the front of a queue is returned, and the queue
		//Post: is left unchanged. Throws QueueException if the queue is empty.
		IComparable dequeue();
		//Pre: none
		//Post: If queue is not empty, the item at the front of the queue is retrieved and removed
		//Post: from the queue. Throws QueueException if the queue is empty.
	}
}
