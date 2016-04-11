FROM dotnetbase
MAINTAINER Don Schenck <don.schenck@gmail.com>

RUN mkdir /speakr
WORKDIR speakr

COPY NuGet.Config .
COPY Controllers .
COPY Models .
COPY node_modules .
COPY Properties .
COPY Views .
COPY wwwroot .
COPY .bowerrc ./
COPY appsettings.json ./
COPY bower.json ./
COPY gulpfile.js ./
COPY package.json ./
COPY Program.cs ./
COPY project.json ./
COPY Project_Readme.html ./
COPY Speakr.xproj ./
COPY Speakr.xproj.user ./
COPY Startup.cs ./

CMD dotnet restore --configfile NuGet.Config && dotnet run
