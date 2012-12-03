using System.ComponentModel;
using System.Threading;
using System.Net.Sockets;
using System;
using System.Net;
using System.Text;


namespace Komponent
{
    partial class CommunicationComponent : Component
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        private bool disposed = false;
	    public delegate void ReceiveEventHandler (object sender, ReceivedEventArgs e);
	    public event ReceiveEventHandler odebranoEvent;
	    Thread thread;
	    Socket client;
	    Socket listener;
	
        //odbior
        protected void onReceiveEvent(Object sender, ReceivedEventArgs e)
        {
            if (odebranoEvent!=null)
            {
	            odebranoEvent(this,e);
            }
        }
	    	

        //nasluch
        public void Nasluchuj(int port)
        {
	        IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any,port);
	        listener = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
	
	        listener.Bind(localEndPoint);
	
	        listener.Listen(10);
	
	        Thread t = new Thread(this.Listen);
	        t.Start(listener);
        }

	
	    public void Listen(object data)
	    {
		    Socket listener = data as Socket;
		    while(true)
		    {
			    try
			    {
				    client = listener.Accept();
				
				    byte[] recv = new byte[100];
				    int bytes;
				    string strRetPage = "";
				
				    do
				    {
					    bytes = client.Receive(recv);
					    //setRetPage = strRetPage + Encoding.UTF8.GetString(recv, 0, bytes);
                        strRetPage += Encoding.UTF8.GetString(recv,0, bytes);
				    } while(client.Connected && client.Available >0);
				
				    onReceiveEvent(this, new ReceivedEventArgs(strRetPage, client.RemoteEndPoint.ToString()));
					
				    client.Close();
			    }
			    catch(SocketException e)
			    {
			        return;
			    }
		    }
	    }
    
        public bool Wyslij(string adres, int port, string tresc)
	    {	    
		    
			    IPHostEntry iphe = Dns.GetHostEntry(adres);
			
			    IPEndPoint ipep = new IPEndPoint(iphe.AddressList[iphe.AddressList.Length == 2 ? 1 : 2], port);

                try
	            {
		            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		
		            s.Connect(ipep);
		
		            //byte[] buff = Encoding.UTF8;
		
		            //send
                    if(!s.Connected)
                    {
                        return false;
                    }
                } 
                catch (Exception e)
                {
                    //
                }

		         //   ...
		            //
		        
                return true;

         	
	    }
        protected override void Dispose(bool disposing)
        {
            if (disposing && !this.disposed)
            {
                if (listener != null) listener.Close();
                if (client != null) client.Close();
                if (thread != null) thread = null;

                GC.SuppressFinalize(this); 
                disposed = true;
            }
        } 

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      /*  protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        #endregion
    }

    

}
