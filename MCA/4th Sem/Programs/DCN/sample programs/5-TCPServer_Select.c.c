//Using select() in the server program


#include "unp.h"

int main(int argc, char **argv)
{
	int i, maxi, maxfd;
	int listenfd, connfd, sockfd;
	int nready, client[FD_SETSIZE];
	ssize_t n;
	fd_set rset, allset;
	char buff[MAXLINE];
	socklen_t clilen;
	struct sockaddr_in cliaddr, servaddr;

	listenfd = socket(AF_INET, SOCK_STREAM, 0);

	bzero(&servaddr, sizeof(servaddr));
	servaddr.sin_family      = AF_INET;
	servaddr.sin_addr.s_addr = htonl(INADDR_ANY);
	servaddr.sin_port        = htons(12352);  
//any port no that you have not used for the other programs...


	bind(listenfd, (struct sockaddr *) &servaddr, sizeof(servaddr));

	listen(listenfd, LISTENQ);

	maxfd = listenfd;	//initialise

	maxi = -1;	//index into client[] array

	for (i=0; i<FD_SETSIZE; i++)
		client[i]=-1;	//-1 indicates available entry

 	FD_ZERO(&allset); //initialise the set to 0
	FD_SET(listenfd, &allset); //turn on bit for listenfd
	
	for(;;) //main for loop
	{
		rset = allset;	//structure assignment
		nready = select(maxfd+1, &rset, NULL, NULL, NULL);

		if(FD_ISSET(listenfd, &rset))	//new client connection
		{
			clilen = sizeof(cliaddr);
			connfd = accept(listenfd, (struct sockaddr*) &cliaddr, &clilen);
			
			for (i=0; i<FD_SETSIZE; i++)
				if(client[i]<0)
				{
					client[i] = connfd;	//save descriptor in the array
					break;
				}
			if(i == FD_SETSIZE)
			{
				printf("\n\n Too many clients\n");
				exit(1);
			}	
			
			FD_SET(connfd, &allset);	//add new descriptor to set
			if(connfd > maxfd)
				maxfd = connfd;		//for select()

			if(i>maxi)
				maxi = i;	//max index in client[] array

			if(--nready <= 0)
				continue;	//no more readable descriptors

		} //endif for new client connection

		for (i=0; i<=maxi; i++)	//check all clients for data
		{
			if((sockfd = client[i])<0)
				continue;

			if(FD_ISSET(sockfd, &rset)) //check if data is ready in the socket
			{
				if((n=read(sockfd, buff, MAXLINE))==0)	//connection closed by client
				{
					close(sockfd);
					FD_CLR(sockfd, &allset); //clear the descriptor from the set
					client[i] = -1; //clear the value in the client array
				}
				else
					write(sockfd, buff, n); //write to client

				if(--nready <=0 )
					break;	//no more readable descriptors
			} //endif for cheking data ready

		}//end for loop for check all clients for data
	} //end main for loop
} // end main funtion
