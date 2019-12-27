// This program is not synchronized.
class Printer {

	//synchronized void print(String msg){
	void print(String msg) {
		System.out.print("[" + msg);
		try {
			Thread.sleep(1000);
		} catch(InterruptedException e) {
			System.out.println("Interrupted");
		}
		System.out.print("]");
	}
}

class Caller implements Runnable {

	String msg;
	Printer p;
	Thread t;

	public Caller(Printer pw, String m) {
		p = pw;
		msg = m;
		t = new Thread(this);
		t.start();
	}

	public void run() {
		//Synchronized block
		synchronized(p){
			p.print(msg);
		}
	}
}

class NoSync{
	public static void main(String args[]) {
		Printer p = new Printer();
		new Caller(p,"Hello");
		new Caller(p,"World");
		new Caller(p,"Synchronized!!!!");		
	}
}
