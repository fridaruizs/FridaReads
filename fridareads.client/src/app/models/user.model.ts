import { Text } from "./text.model";

export interface User {
    username: string;
    email: string;
    password: string;
    isAdmin: boolean;
    texts: Text[];
  }
  