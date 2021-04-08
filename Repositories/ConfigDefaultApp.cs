using G10COMERCIALIZADORA_DOTNET.Models;
using Microsoft.EntityFrameworkCore;

namespace G10COMERCIALIZADORA_DOTNET.Repositories
{
    public class ConfigDefaultApp
    {
        public static void CreateConfigDefault(ModelBuilder modelBuilder)
        {
            KeysApp key = new KeysApp();
            key.KeysAppId = 1;
            key.Pkcs8PrivateKeyBase64 = "MIIFNDBeBgkqhkiG9w0BBQ0wUTAwBgkqhkiG9w0BBQwwIwQQRyw6Ug7kzM5C/l8r51G3EwIBIDAMBggqhkiG9w0CCQUAMB0GCWCGSAFlAwQBKgQQIxVb1guWSCkPf2SWf8GZDQSCBNC72ncyP7AyFQ7Ho4F2nKN8x28lrRqT/Z8W8nx83IcYIHfA3fZjyfGrc7JmJR2MwkpinnHXNLk/KxrgeR5WIpzEySzkBRaUDQOi6hUxI/2CEvpf5w3pfuOh2VkV2oOxdnLlMm2bzXQIMilw5HCnKmdBQJweDDoQHH5bmrOkrz5geMQ5qgksOUlQkspW6kia4IGitao4+ZhgJ33TNRrK/Wy39V0iNrPFSJapJ39llJaXKClho7V/vGqSRkcE7USwptdR0Nl7rCURPE7lMWTLMfpEy8NOHec0TDEdKkP4hmgikiVoBJ/oqjGtYOMQBQuF6AIurvjFCwG5nKLG/mPdZNg5b9b+Rh7v+T1CA/UPnWZEhR7B2F9UlC4U2KLRPamMeZ/3IlBM77fq2AGsE0Zjt6i+H881R+mZiBWn/KpiSKBzXTccO4fpvRxXxfuS6FDej7Ed6MJkiqSWOXmcmkrkpwst8Pnhfrb0ps4PI2I4va6Gak++hzgJFfCOwy+tJ4oP+maQGbGWhEdw0EXcX4kPkDqFjC+kWQn+5pw62C6ijSh6jAClDmsp5ZvFh+YVA5+mkV6bXBb70/xiuOCwB+pvS43pHk9LB1xaX7YKs5jKKuMSnf9scSuUrZ7iFVXSsDw+uCQRh52IlaCoz606lkdmTdVgttnK2bpeqKCQHivTz1ZAhD/ZgI++tIcm2QXFFgGKZpH1WuWyLrhYkpYLg+Y6bhT1tGOVz2wJ5zXxwC8RrPrrw7De64mT6SCBr5xFnr8mkCg0QgBKfY3Nutjh13RaWagApy25sZiT8msFsYnuOn61t/xwQdJGD01DiTTwadbSOkFVMszXfa+yXfi9NTVMLelBd2Wm5q3a1aau60Oy/BA8iqeC+TPSetaRMYTcDv3qNpGn882/RQfb69mlfClEoup9bEbCDMk3vR6uAqnGM6IUeVX4bEsn7jfuGZRTvYPstJqpHePbEcVFCt/PkxGcLn1I14vSdS/ug8afyXGYyhL33BFqaH8G8HcpEgUWq39lDY+ECuIUU2UW4aodCHmqvQIXsHTmCkLf8z7Su7KenMtt3XYyQ2FHpkgc1A3AQw6WgZpx7lEPHae5+Z0AXq7GHUWQ2T2L/V9Q2XzorlPsbyHxUalbicJH4PDN0fRCRKnBzXrONeSbJhI7GM/DYLFMHp/Jym0TV5Nf93GAqapvO55gHOuBLZMXTtVREAVVbVUxDFQCvVGdjx/IqBDU4B9o0sBISf5BEXzNNZPVrospOziKbULNDV+mBQPuWNaXh0TXLvac+wN2fWldTMDI42NFpmmIn27NmEeBfc2d2UEVaBr3AxSvD0Gv2EmhUrXH/GWStnBRQNoxcurB29xooBjrOZpxzmYtxiyqLeORLXktQE/wq/k/yG2nSaNsAx8E7K3ZMYN0Jvl9MNAj1L6hP4dd7tJgI3jloAmEaJzGplGBkZDFxu4eWPuY2y++kspr6qJHy4s2/Yl9ioU6ZH2onzcGBaA7t5j2F0pebcvxvFoW4wFV6qSLw5um0CQ+CnH6dqU1KS2fh+kGLpVyc6pEQHQy5h4l1Fyb7OdJTVgGQzNz+MRdNudCqSiWsGpubg+ZjE8Ymi0ybVADFLfZIdUFrqTo6E2i40r9COTXRb5pS0/IlhRnuw==";
            key.X509CertBase64 = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAnz5Tx7YPO7pWUej5XL9boSe0oaYq9hqDfDMNW25ue1t2BYs+UQ6ohy68IKXhW99iznJofrusqARRznqfFBmO3eGzkICkngWFygni4ZThPZFX8GpOanmvZpU4Jo6aXZ0ZM2eSWKSHs3FUFVjPuHmX4kY/gin4yQt5/2jNw5SZQ1kQtTnxhJHbCj67Uaq5nJqDFkq+TRNHDPGPOht1knZEo3spP7BdBhnLgf7lLaXzJr6ZjPuuVHrEOISEap0JU5Pox7l5IpvvFmOmH6F/5O5d/CvWguFBr/GgXDyUs4MWEVDU/NoCE3no79MhT39xJJnuYJ2BDGdY9d9O0VlMFYG5iwIDAQAB";
            key.IsEnable = true;

            modelBuilder.Entity<KeysApp>().HasData(key);

            Configurations config = new Configurations();
            config.ConfigurationsId = 1;
            config.nameSetting = "passEncriptPrivatedKeysRSA";
            config.valueSetting = "secreto";
            config.description = "Contraseña para encriptar la Llaves Privadas del RSA";

            modelBuilder.Entity<Configurations>().HasData(config);

            
        }
    }
}