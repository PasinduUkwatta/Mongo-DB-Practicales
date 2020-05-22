import com.mongodb.client.MongoClients;
import com.mongodb.client.MongoDatabase;

public class MongoDbConnection {
    public static void main(String[] args) {
      try (var mongoClient = MongoClients.create("mongodb://localhost:27017")){
          MongoDatabase database =mongoClient.getDatabase("Northwind");
          System.out.println("  "+database.getName());

          for (String name :database.listCollectionNames()){
              System.out.println(name);
          }
      }
    }
}
