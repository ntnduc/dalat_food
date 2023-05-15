# Wellcome to Da Lat Food project
## Step start project
### Font End:
'''
Start with HTTPS
'''
---
- Install mkcert to use https local: `brew install mkcert`
- Setup mkcert in your desk: `mkcert -install`
- From ~/root/front-end create new file ".cert" if it dont exist yet: `mkdir -p .cert`
- Create new a certificate: `mkcert -key-file ./.cert/key.pem -cert-file ./.cert/cert.pem "localhost"`
- Start fe: `npm start`
---

'''
Start with HTTP
'''
---
- Start fe: `npm start startHttp`
---


