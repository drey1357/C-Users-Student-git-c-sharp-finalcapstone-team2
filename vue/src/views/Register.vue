<template>
  <div id="register" class="text-center">
    <form class="form-register" @submit.prevent="register">
      <h1 class="h3 mb-3 font-weight-normal">Create Account</h1>
      <div class="alert alert-danger" role="alert" v-if="registrationErrors">
        {{ registrationErrorMsg }}
      </div>
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
      <input
        type="password"
        id="confirmPassword"
        class="form-control"
        placeholder="Confirm Password"
        v-model="user.confirmPassword"
        required
      />
      <br/>
      <br/>
      <router-link :to="{ name: 'login' }">Have an account?</router-link>
      <br/>
      <br/>
      <button class="btn btn-lg btn-primary btn-block" type="submit">
        Create Account
      </button>
    </form>
    <div class="copy">
&copy; 2022 DDMS Business Solutions
</div>
  </div>
</template>

<script>
import authService from '../services/AuthService';

export default {
  name: 'register',
  data() {
    return {
      user: {
        username: '',
        password: '',
        confirmPassword: '',
        role: 'user',
        // address: ''
      },
      registrationErrors: false,
      registrationErrorMsg: 'There were problems registering this user.',
    };
  },
  methods: {
    register() {
      if (this.user.password != this.user.confirmPassword) {
        this.registrationErrors = true;
        this.registrationErrorMsg = 'Password & Confirm Password do not match.';
      } else {
        authService
          .register(this.user)
          .then((response) => {
            if (response.status == 201) {
              this.$router.push({
                path: '/login',
                query: { registration: 'success' },
              });
            }
          })
          .catch((error) => {
            const response = error.response;
            this.registrationErrors = true;
            if (response.status === 400) {
              this.registrationErrorMsg = 'Bad Request: Validation Errors';
            }
          });
      }
    },
    clearErrors() {
      this.registrationErrors = false;
      this.registrationErrorMsg = 'There were problems registering this user.';
    },
  },
};
</script>

<style>
@import url('https://fonts.googleapis.com/css2?family=Press+Start+2P&display=swap');

.text-center{
  display: flex;
  justify-content: center;
  background-color: floralwhite;
  margin-left: auto;
  margin-right:auto;
  width: 75%;
  height: 100vh;
}

#register{
  text-align: center;
}

#register > form > h1{
  font-family: 'Lusitana', serif;
  font-size: 15px;
}

#register > form > a{
  font-family: 'Lusitana', serif;
  font-size: 12
  px;
}

#register > div{

  position: fixed;
    bottom:5px;
    width: 100%;
    left:0px;
    height:25px;
}
</style>
