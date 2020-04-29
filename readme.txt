resources:

raspbian download:
https://www.raspberrypi.org/downloads/raspbian/

raspbian imaging:
https://www.raspberrypi.org/documentation/installation/installing-images/README.md

Disk Imager:
etcher, win32diskimager, or raspbarry pi imager

Install .net core
https://elbruno.com/2019/12/30/raspberypi-how-to-install-net-core-3-1-in-a-raspberry-pi-4/
	One note about this article. It states to install into $home/dotnet however this does not appear to be a default supported install path my microsoft and i had issues with this. Per the article i found it should have been fine after 3.0 but i still experienced issues. For this reason i went with the default install path of /usr/share/dotnet
	I downloaded .net core package from https://dotnet.microsoft.com/download/dotnet-core/3.1
	For the most stable build use the arm32 package. Raspbian rescently released a 64 bit option but still is very new and being tested.

Commands:
sudo mkdir -p /usr/share/dotnet
sudo tar zxf dotnet-sdk-3.1.201-linux-arm.tar.gz -C /usr/share/dotnet
export DOTNET_ROOT=/usr/share/dotnet
export PATH=$PATH:/usr/share/dotnet

Add the following to your .profile(sudo nano ${HOME}/.profile) before reboot or paths will not exist after boot.
DOTNET_ROOT=/usr/share/dotnet
PATH=$PATH:/usr/share/dotnet

Install vscode
https://pimylifeup.com/raspberry-pi-visual-studio-code/
Commands:
wget https://packagecloud.io/headmelted/codebuilds/gpgkey -O - | sudo apt-key add -
sudo apt-get install code-oss


Install mariadb
https://raspberrytips.com/install-mariadb-raspberry-pi/
	To be able to connect to the server remotely add the following to the end of /etc/mysql/mariadb.conf.d/50-server.cnf
	[mysqld]
	skip-networking=0
	skip-bind-address

Dotnet command options for creating resources
https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new

EFCore setup for .net core
https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core-example.html