//Daytime Server - Print the date and time of the server

#include <stdio.h>
#include <stdlib.h>
#include <sys/socket.h>
#include <arpa/inet.h>
//#include<inet/arpa.h>
#include<string.h>
#include <time.h>
#define MAXLINE 100
#define LISTENQ 10


int main(int argc, char **argv)
{
	int listenfd, connfd;
	struct sockaddr_in servaddr;
	char buff[MAXLINE];
	time_t ticks;
//CREATE A TCP SOCKET
	listenfd = socket(AF_INET, SOCK_STREAM, 0);
//BIND SERVER'S WELL KNOWN PORTS TO SOCKET
	bzero(&servaddr, sizeof(servaddr));
	servaddr.sin_family      = AF_INET;
	servaddr.sin_addr.s_addr = htonl(INADDR_ANY); //server accepts client connection on any interface
	servaddr.sin_port        = htons(1025);	/* daytime server */ //use port nos above 1024 for non-priviledged users
	bind(listenfd, (struct sockaddr *) &servaddr, sizeof(servaddr));
//CONVERT SOCKET TO LISTENING SOCKET
	listen(listenfd, LISTENQ);
//ACCEPT CLIENT CONNECTION AND SEND REPLY
	for ( ; ; ) 
	{
		connfd = accept(listenfd, (struct sockaddr *) NULL, NULL);
	      ticks = time(NULL);
        	snprintf(buff, sizeof(buff), "%s\r\n", ctime(&ticks));
		write (connfd, buff, strlen(buff));
		close(connfd);
	}
	 }
