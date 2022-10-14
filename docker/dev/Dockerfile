FROM ubuntu:latest

RUN apt update && apt install -y openssh-server git dotnet6

RUN echo 'PermitRootLogin Yes' >> /etc/ssh/sshd_config

RUN echo 'root:dev' | chpasswd

RUN service ssh start

WORKDIR /app

EXPOSE 22

CMD ["/usr/sbin/sshd", "-D"]