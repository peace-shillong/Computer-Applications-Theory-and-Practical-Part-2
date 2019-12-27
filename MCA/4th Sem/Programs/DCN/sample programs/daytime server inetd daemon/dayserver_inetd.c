//filename : dayserver_inetd.c

#include "/root/linux/unp.h"
#include "daemon_inetd.c"
#include <time.h>
#include <syslog.h>


void daemon_inetd(const char *pname, int facility)
{
	openlog(pname, LOG_PID, facility);
}


int main(int argc, char **argv)
{
	socklen_t addrlen, len;
	char buff[MAXLINE];
	time_t ticks;
	struct sockaddr *cliaddr;

	daemon_inetd(argv[0], 0);

//since we do not call tcp_listen(), we don't know the size of
//socket address structure that it returns
//since we do not call accept(), we don't know client's
//protocol address. We allocate a buffer for the address structure
//using MAXSOCKADDR constant and call getpeername() with //descriptor 0 as first arg. 
	
	cliaddr=malloc(sizeof(struct sockaddr));

	ticks=time(NULL);
	snprintf(buff, sizeof(buff), "%s\r\n", ctime(&ticks));
	write(0, buff, strlen(buff));
	close(0);	//close TCP connection
	exit(0);
}

//for running this pgm
//---------------------------------------------------------------
//Assign service a name and port, adding following line to /etc/services
//	mydaytime	9999/tcp
//then add a line to /etc/inetd.conf
//	mydaytime  stream  tcp  nowait  rstevens  
//	        	/usr/home/rstevens/dayserver_inetd  dayserver_inetd
//place the executable in specified file and send SIGHUP signal to inetd,
//telling it to reread conf file. The next step is to execute netstat
//to verify that a listening socket has been created on TCP port 9999.
//	netstat  -na | grep 9999
//then invoke server from another host
//	telnet  unix   9999
//The /var/log/messages file contains entry

