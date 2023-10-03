Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

String respuesta = "Your subscription";

if(daysUntilExpiration<=11){
    if (daysUntilExpiration<=5){
        if(daysUntilExpiration<=1){
            if(daysUntilExpiration==0){
                respuesta+=" has expired";
            }else{
                discountPercentage = 20;
                respuesta+=$" expires within a day! ";
            }
        }else{
            discountPercentage=10;
            respuesta +=$"expires in {daysUntilExpiration} days. ";
        }
    }else{
        respuesta +=" will expire soon. Renew now!";
    }
}
if (discountPercentage > 0)
{
    respuesta+=$"Renew now and save {discountPercentage}%.";
}

Console.WriteLine(respuesta);
