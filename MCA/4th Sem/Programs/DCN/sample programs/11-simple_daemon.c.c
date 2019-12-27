//create a simple daemon process
//this program will print text into a file in the background


#include "unp.h"

int main(int argc, char **argv)
{
	int pid;
	
	if (fork())
		return 0;

	chdir ("/");
	setsid();
	umask(0);

	pid=fork();
	if(pid)
	{
		printf("\n Daemon : %d\n", pid);
		return 0;
	}

	FILE *f;
	f=fopen("daemon.log","w"); //this file should exist							

	while(1)
	{
		fprintf(f, "Daemon testing\n");
		fflush(f);
		sleep(2);
	}
}


//note: try to run this program and notice that no terminal will //be used. Also, the filename daemon.log will have some text that //was created by the pogram.
