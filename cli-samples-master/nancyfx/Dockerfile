FROM registry.access.redhat.com/rhel7

RUN yum install -y libunwind libicu && yum clean all

ADD bin/Release/netcoreapp1.0/rhel.7.2-x64/publish/. /opt/app-root/src/

WORKDIR /opt/app-root/src/

EXPOSE 5000 

CMD ["/bin/bash", "-c", "/opt/app-root/src/dotnet_docker_msa"]
