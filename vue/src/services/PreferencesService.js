import axios from 'axios';
import store from '@/store/index';


const http = axios.create({

    baseURL: "https://localhost:44315",
    headers: {'Authorization': 'Bearer '+ `${store.state.token}`}
    //hard coded token
    // headers: {'Authorization': 'Bearer ' + "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIzIiwibmFtZSI6InRlc3QxIiwicm9sZSI6InVzZXIiLCJuYmYiOjE2NTk5ODQxOTUsImV4cCI6MTY2MDU4ODk5NSwiaWF0IjoxNjU5OTg0MTk1fQ.3eykv3uTtAYtxzAHE0ERDpk1TwTISZzyL2k9-EDQqM4"}
});


export default {
    getPreferencesByUserId(userId){
        return http.get(`/preferences/${userId}`); 
    }
  

}