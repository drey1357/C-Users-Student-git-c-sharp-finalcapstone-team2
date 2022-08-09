import axios from 'axios';

const http = axios.create({
    baseURL: "https://localhost:44315"
  });

export default {
    getPreferencesByUserId(){
        return http.get("/preferences/5"); 
    }
  

}