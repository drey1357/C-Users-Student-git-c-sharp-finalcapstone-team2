<template>
  <div>
    <p>(click name for more details)</p>
    <h1>restaurant name</h1>
    <img src="" alt="" /><p>image</p>
    <p>tags</p>
  </div>
</template>

<script>
export default {
    name: "restaurant-card",
    data(){
        return{
            restaurant:{
                    id: "",
                    name: "",
                image_url:"",
                is_closed: false,
                url: "",
                categories: [
                    {
                        alias: "",
                        title: ""
                    }
                ],
                rating: 0.0,
                location: {
                    address1: "",
                    address2: null,
                    address3: null,
                    city: "",
                    zip_code: "",
                    country: "US",
                    state: "",
                    display_address: [
                        "",
                        ""
                    ]
                },
                phone: "",
                display_phone: "",
                distance: "",
            }
        }
    }

}
</script>

<style>

</style>