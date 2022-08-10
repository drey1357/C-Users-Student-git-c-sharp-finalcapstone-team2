<template>
  <div class="main">
    <p>(click name for more details)</p>
    <tr v-for="restaurant in restaurants" v-bind:key="restaurant.id"> {{restaurant.name}}</tr>
    <p>image</p>
    <p>tags</p>
  </div>
</template>

<script>
import YelpAPIService from "@/services/YelpAPIService.js"

export default {
    name: "restaurant-card",
    data(){
        return{
            restaurants: [{
                id: "",
                alias: "",
                name: "",
                image_url: "",
                is_closed: false,
                url: "",
                review_count: 0,
                categories: [
                    {
                        alias: "",
                        title: ""
                    },
                ],
                rating: 0.0,
                coordinates: {
                    latitude: 0.0,
                    longitude: 0.0
                },
                transactions: [
                    ""
                ],
                price: "",
                location: {
                    address1: "",
                    address2: "",
                    address3: "",
                    city: "",
                    zip_code: "",
                    country: "",
                    state: "",
                    display_address: [
                        "",
                        ""
                    ]
                },
                phone: "",
                display_phone: "",
                distance: 0.0
                }],
        total: 0,
        region: {
            center: {
                longitude: 0.0,
                latitude: 0.0
            }
    }
        }
    },
    created(){
        YelpAPIService.getRestaurants().then((response) => {
        let data = response.data;
        this.restaurants = data;
        });
    }


}
</script>

<style>
#app > div.home > div:nth-child(8){
    border-style: solid
}

</style>