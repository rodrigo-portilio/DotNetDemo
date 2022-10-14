#!/bin/bash
echo "generating certificate"

cd /app/docker/dev/certify

openssl req -x509 -nodes -days 365 -newkey rsa:2048 \
               -keyout localhost.key \
               -out localhost.crt \
               -config localhost.conf

cp localhost.crt /usr/local/share/ca-certificates

update-ca-certificates

openssl verify localhost.crt

openssl pkcs12 -export -out localhost.pfx -inkey localhost.key -in localhost.crt

dotnet dev-certs https --clean --import ./localhost.pfx -p