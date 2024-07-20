using json_test.models;// Importa los modelos personalizados del proyecto
using System.Text.Json;// Proporciona funcionalidad para trabajar con JSON
using System.Text.Json.Serialization;// Ofrece atributos para controlar la serialización
using System.Threading.Tasks;// Permite el uso de programación asíncrona
using System.Net.Http;// Proporciona una clase para enviar solicitudes HTTP y recibir respuestas

public class Program
{
    static async Task Main(string[] args)
    {
        //SERIALIZACION -> La serialización es el proceso de convertir un objeto en un formato que puede ser fácilmente almacenado o transmitido (como un archivo JSON).

        // Crea una nueva instancia de la clase Beer con un ID de 10 y nombre "Cerveza"
        // Beer beer = new Beer(10, "Cerveza");

        // // Serializa el objeto beer a una cadena JSON
        // string myJson = JsonSerializer.Serialize(beer);
        // // Escribe la cadena JSON en un archivo llamado "objetto.txt"
        // // Si el archivo ya existe, se sobrescribe; si no existe, se crea
        // File.WriteAllText("objetto.txt", myJson);

        //DESERIALIZACION --> La deserialización es el proceso inverso, donde conviertes una cadena JSON en un objeto

        // Lee todo el contenido del archivo "objetto.txt" y lo almacena en la variable myJson como una cadena
        // string myJson = File.ReadAllText("objetto.txt");

        // // Deserializa la cadena JSON (myJson) a un objeto de tipo Beer
        // // El operador '!' al final indica que estamos seguros de que el resultado no será null
        // Beer beer = JsonSerializer.Deserialize<Beer>(myJson)!;

        //GET
        // Define la URL de la API que vamos a consultar
        string url = "https://jsonplaceholder.typicode.com/posts";
        // Crea una instancia de HttpClient para realizar solicitudes HTTP
        HttpClient client = new HttpClient();

        // Realiza una solicitud GET asíncrona a la URL especificada
        var httpResponse = await client.GetAsync(url);

        // Verifica si la solicitud fue exitosa (código de estado 200-299)
        if (httpResponse.IsSuccessStatusCode)
        {
            // Lee el contenido de la respuesta como una cadena de texto de forma asíncrona
            var content = await httpResponse.Content.ReadAsStringAsync();

            // Deserializa el contenido JSON a una lista de objetos Post
            // El operador '!' indica que estamos seguros de que el resultado no será null
            List<Post> posts =
                JsonSerializer.Deserialize<List<Post>>(content)!;
        }

        //POST - PUT - DELETE
        //// Define la URL para operaciones POST
        // string url = "https://jsonplaceholder.typicode.com/posts";

        //// Define la URL para operaciones PUT y DELETE
        // string url = "https://jsonplaceholder.typicode.com/posts/99";

        //// Crea una instancia de HttpClient para realizar solicitudes HTTP
        // HttpClient client = new HttpClient();

        //// Crea un nuevo objeto Post con datos de ejemplo
        // Post post = new Post()
        // {
        //     userId = 50,
        //     body = "Hola soy un body",
        //     title = "Hola osy un titulo"
        // };

        //// Serializa el objeto Post a una cadena JSON
        //var data = JsonSerializer.Serialize<Post>(post);

        //// Crea el contenido de la solicitud HTTP con el JSON serializado
        //// Especifica la codificación UTF-8 y el tipo de contenido como application/json
        //HttpContent content = 
        //    new StringContent(data, System.Text.Encoding.UTF8, "application/json");

        //// Realiza una solicitud POST asíncrona
        // var httpResponse = await client.PostAsync(url, content);//POST

        //// Realiza una solicitud PUT asíncrona
        // var httpResponse = await client.PutAsync(url, content);//PUT

        //// Realiza una solicitud DELETE asíncrona
        // var httpResponse = await client.DeleteAsync(url);//DELETE

        //// Verifica si la solicitud fue exitosa (código de estado 200-299)
        // if(httpResponse.IsSuccessStatusCode)
        {
            // Lee el contenido de la respuesta como una cadena de texto de forma asíncrona
            var result = await httpResponse.Content.ReadAsStringAsync();
            // Deserializa la respuesta JSON a un objeto Post
            var postResult = JsonSerializer.Deserialize<Post>(result);
        }

    }
}