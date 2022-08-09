import axios from 'axios';

const http = axios.create(); //create the axios instance, we're not using a base URL this time

export default {
    getRestaurants(){
        //the API brings back a JSON object with a quote property
        return http.get('https://api.yelp.com/v3/businesses/search?location=7100 Euclid Avenue, Cleveland, OH 44103&term=food, pizza&radius=40000'); 
        //returning the Promise object -- handle it in the Vue component
    }
  

}