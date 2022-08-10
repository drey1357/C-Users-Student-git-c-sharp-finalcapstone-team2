<template>
  <div id="login" class="text-center">
    <form class="form-signin" @submit.prevent="login">
      <h1 class="h3 mb-3 font-weight-normal">Please Sign In</h1>
      <div
        class="alert alert-danger"
        role="alert"
        v-if="invalidCredentials"
      >Invalid username and password!</div>
      <div
        class="alert alert-success"
        role="alert"
        v-if="this.$route.query.registration"
      >Thank you for registering, please sign in.</div>
      <!-- <label for="username" class="sr-only">Username</label> -->
      <input
        type="text"
        id="username"
        class="form-control"
        placeholder="Username"
        v-model="user.username"
        required
        autofocus
      />
      <br/>
      <br/>
      <!-- <label for="password" class="sr-only">Password</label> -->
      <input
        type="password"
        id="password"
        class="form-control"
        placeholder="Password"
        v-model="user.password"
        required
      />
      <br/>
      <br/>
      <router-link :to="{ name: 'register' }">Need an account?</router-link>
      <br/>
      <br/>
      <button type="submit">Sign in</button>
    </form>

    <div class="copy">
&copy; 2022 DDMS Business Solutions
</div>
  </div>
</template>

<script>
import authService from "../services/AuthService";

export default {
  name: "login",
  components: {},
  data() {
    return {
      user: {
        username: "",
        password: ""
      },
      invalidCredentials: false
    };
  },
  methods: {
    login() {
      authService
        .login(this.user)
        .then(response => {
          if (response.status == 200) {
            this.$store.commit("SET_AUTH_TOKEN", response.data.token);
            this.$store.commit("SET_USER", response.data.user);
            this.$router.push("/");
          }
        })
        .catch(error => {
          const response = error.response;

          if (response.status === 401) {
            this.invalidCredentials = true;
          }
        });
    }
  }
};
</script>

<style>

#login{
  display: flex;
  justify-content: center;
  margin-left: auto;
  margin-right:auto;
  width: 75%;
  height: 100vh;
  background-color: floralwhite;
  text-align: center;
  
}

#login > form > h1{
  font-family: 'Lusitana', serif;
  font-size: 15px;
  text-align: center;
}
#login > form > a{
  font-family: 'Lusitana', serif;
  font-size: 12px;
}

#login > div{
  position: fixed;
    bottom:5px;
    width: 100%;
    left:0px;
    height:25px;
}

/* #login > form > button{
  border: solid;
  border-width: .25px;
  border-radius: 15px;
  border-color: lightgray;
  margin-right: 5px;
  padding-top: 5px;
  padding-left: 15px;
  padding-bottom: 5px;
  padding-right: 15px;
 
}

#login > form > button:hover{
  background-color: darkgray;
} */


</style>
