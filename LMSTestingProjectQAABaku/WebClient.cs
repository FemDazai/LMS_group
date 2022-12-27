using System.Net.Http.Headers;
using System.Net;
using System.Text;
using LMSTestingProjectQAABaku.Models;
using System.Text.Json;
using LMSTestingProjectQAABaku.ModelsApi;

namespace LMSTestingProjectQAABaku
{
    public class WebClient
    {
        public void SetRole(string token, int id, string role)
        {
            HttpStatusCode expectedCode = HttpStatusCode.NoContent;
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:7070/api/Users/{id}/role/{role}"),
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;

        }

        public string Auth(AuthRequestModelApi model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.OK;
            string json = JsonSerializer.Serialize<AuthRequestModelApi>(model);
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:7070/sign-in"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;
            string token = responseMessage.Content.ReadAsStringAsync().Result;

            return token;
        }

        public int GetUserId(RequestModelApi model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string json = JsonSerializer.Serialize<RequestModelApi>(model);
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:7070/register"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            string responseJson = responseMessage.Content.ReadAsStringAsync().Result;
            RegistrationResponseModel InfoUser = JsonSerializer.Deserialize<RegistrationResponseModel>(responseJson)!;

            return InfoUser.id;
        }

        public int GetIdCreatedGroup(string token, CreateGroupeModelApi model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string json = JsonSerializer.Serialize<CreateGroupeModelApi>(model);
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:7070/api/Groups"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;
            string responseJson = responseMessage.Content.ReadAsStringAsync().Result;
            CreateGroupResponseModelApi InfoGroup = JsonSerializer.Deserialize<CreateGroupResponseModelApi>(responseJson)!;

            return InfoGroup.id;
        }
        
        public int GetIdCreatedCourse(string token, CreateCourseModelApi model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string json = JsonSerializer.Serialize<CreateCourseModelApi>(model);
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:7070/api/Courses"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;
            string responseJson = responseMessage.Content.ReadAsStringAsync().Result;
            CreateCourseResponseModelApi InfoCourse = JsonSerializer.Deserialize<CreateCourseResponseModelApi>(responseJson)!;

            return InfoCourse.id;
        }

        public int GetIdTask(string token, TaskRequestModelApi model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string json = JsonSerializer.Serialize<TaskRequestModelApi>(model);
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:7070/api/Tasks/teacher"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;
            string responseJson = responseMessage.Content.ReadAsStringAsync().Result;
            TasksResponseModelApi InfoTask = JsonSerializer.Deserialize<TasksResponseModelApi>(responseJson)!;

            return InfoTask.id;
        }

        public int GetCreateHomework(string token, int groupId, int taskId, HomeworkRequestModelApi model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string json = JsonSerializer.Serialize<HomeworkRequestModelApi>(model);
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:7070/api/Homeworks/group/{groupId}/task/{taskId}"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;
            string responseJson = responseMessage.Content.ReadAsStringAsync().Result;
            HomeworkResponseModelApi HomeworkId = JsonSerializer.Deserialize<HomeworkResponseModelApi>(responseJson)!;

            return HomeworkId.id;
        }

        public void AddUsers(string token, int groupId, int userId, int roleId)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:7070/api/Groups/{groupId}/user/{userId}/role/{roleId}")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;
        }

    }
}

